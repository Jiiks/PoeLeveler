using Newtonsoft.Json;
using NHotkey;
using NHotkey.WindowsForms;
using System.Reflection;

namespace PoeLeveler {

    public partial class Form1 : Form {

        private Image _socketSheet;

        private int _currentStep = 0;
        private List<Step> _steps = [];

        public Step GetCurrentStep() {
            if (_currentStep > _steps.Count - 1) return _steps[_currentStep - 1];
            return _steps[_currentStep];
        }

        public Step GetNextStep() {
            if (_currentStep + 1 >= _steps.Count) return _steps[_currentStep];
            return _steps[_currentStep + 1];

        }

        public void RegisterHotkeys() {

            HotkeyManager.Current.AddOrReplace("NextStep", Keys.NumPad6, NextStep);
            HotkeyManager.Current.AddOrReplace("PrevStep", Keys.NumPad4, PrevStep);
            HotkeyManager.Current.AddOrReplace("RegexCopy", Keys.NumPad5, RegexCopy);

        }

        private void RegexCopy(object? sender, HotkeyEventArgs e) {
            Clipboard.SetText(lblRegex.Text);
        }

        private void PrevStep(object? sender, HotkeyEventArgs e) {
            if (_currentStep - 1 < 0) return;
            _currentStep--;
            UpdateSteps();
        }

        private void NextStep(object? sender, HotkeyEventArgs e) {
            if (_currentStep + 1 >= _steps.Count) return;
            _currentStep++;
            UpdateSteps();
        }

        public Form1() {
            InitializeComponent();
            RegisterHotkeys();

            this.FormClosing += Form1_FormClosing;

            var executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (executablePath == null) {
                MessageBox.Show("Failed to get directory");
                return;
            }
            var steps = JsonConvert.DeserializeObject<List<Step>>(File.ReadAllText("route.json"));
            if (steps == null) {
                MessageBox.Show("Failed to deserialize route.json");
                return;
            }

            _steps = steps;
            _steps.Add(new Step() {
                Steps = ["Finished!"]
            });

            var imagesDir = Path.Combine(executablePath, "images");
            _socketSheet = Image.FromFile(Path.Combine(imagesDir, "sockets.png"));

            foreach (var step in _steps) {
                step.Init(imagesDir);
            }

            UpdateSteps();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e) {
            HotkeyManager.Current.Remove("NextStep");
            HotkeyManager.Current.Remove("PrevStep");
            HotkeyManager.Current.Remove("RegexCopy");
        }

        public void UpdateSteps() {
            stepsBox.Items.Clear();

            var currentStep = GetCurrentStep();

            foreach (var step in currentStep.Steps) {
                stepsBox.Items.Add(step);
                if (currentStep.PassiveTree != null)
                    passiveTree.Image = currentStep.PassiveTree;
            }

            nextStepsBox.Items.Clear();

            var nextStep = GetNextStep();
            foreach (var step in nextStep.Steps) {
                nextStepsBox.Items.Add(step);
                if (currentStep.PassiveTree != null)
                    passiveTree.Image = currentStep.PassiveTree;
            }

            flowLayoutPanel1.Controls.Clear();

            if (currentStep.Links != null) {
                foreach (var socketGroup in currentStep.Links) {
                    var sg = new SocketGroup(_socketSheet, socketGroup) {
                        Parent = flowLayoutPanel1
                    };
                }
            }

            if (currentStep.Regex != null) {
                lblRegex.Text = currentStep.Regex;
            }
        }

        private void cbAlwaysOnTop_CheckedChanged(object sender, EventArgs e) {
            TopMost = cbAlwaysOnTop.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void numericFontSize_ValueChanged(object sender, EventArgs e) {
            label1.Font = lblRegex.Font = nextStepsBox.Font = stepsBox.Font = new Font(stepsBox.Font.FontFamily, (float)numericFontSize.Value);
        }
    }
}
