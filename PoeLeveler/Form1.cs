using Newtonsoft.Json;
using NHotkey;
using NHotkey.WindowsForms;
using System.Reflection;

namespace PoeLeveler {

    public partial class Form1 : Form {

        private int _currentStep = 0;
        private readonly List<Step> _steps = [];

        private Image? _socketSheet;

        public Form1() {
            InitializeComponent();
            RegisterHotkeys();
            FormClosing += RemoveHotkeys;
            if (!Initialize()) return;
            UpdateSteps();
        }

        private bool Initialize() {
            if (!File.Exists("route.json")) {
                MessageBox.Show("Missing route.json");
                return false;
            }

            var executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (executablePath == null) {
                MessageBox.Show("Failed to get directory");
                return false;
            }
            List<Step>? steps;
            try {
                steps = JsonConvert.DeserializeObject<List<Step>>(File.ReadAllText("route.json"));
            }catch(Exception e) {
                MessageBox.Show($"Failed to deserialize route.json {e.Message}");
                return false;
            }
            if (steps == null) {
                MessageBox.Show("Failed to deserialize route.json");
                return false;
            }

            var imagesDir = Path.Combine(executablePath, "images");
            if (!Directory.Exists(imagesDir)) {
                MessageBox.Show("Images dir does not exist");
                return false;
            }

            if (!File.Exists(Path.Combine(imagesDir, "sockets.png"))) {
                MessageBox.Show("Missing sockets.png in images dir");
                return false;
            }
            _socketSheet = Image.FromFile(Path.Combine(imagesDir, "sockets.png"));

            cbStep.Items.Clear();
            foreach (var step in steps) {
                step.Init(Path.Combine(executablePath, "images"));
                _steps.Add(step);
                cbStep.Items.Add(step.Id);
                cbStep.SelectedIndex = 0;
            }

            _steps.Add(new Step() {
                Id = "_Finished_",
                Steps = ["Finished!"]
            });
            cbStep.Items.Add("_Finished_");

            return true;
        }

        private void NextStep() {
            if (_currentStep + 1 >= _steps.Count) return;
            _currentStep++;
            UpdateSteps();
        }
        private void PrevStep() {
            if (_currentStep - 1 < 0) return;
            _currentStep--;
            UpdateSteps();
        }

        private Step GetCurrentStep() {
            if (_currentStep > _steps.Count - 1) return _steps[_currentStep - 1];
            return _steps[_currentStep];
        }

        private Step GetNextStep() {
            if (_currentStep + 1 >= _steps.Count) return _steps[_currentStep];
            return _steps[_currentStep + 1];
        }

        private void UpdateSteps() {
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

            if (currentStep.Links != null && _socketSheet != null) {
                foreach (var socketGroup in currentStep.Links) {
                    _ = new SocketGroup(_socketSheet, socketGroup) {
                        Parent = flowLayoutPanel1
                    };
                }
            }

            if (currentStep.Regex != null) {
                lblRegex.Text = currentStep.Regex;
            }

            cbStep.SelectedIndex = _currentStep;
        }

        private void CopyRegex() {
            Clipboard.SetText(lblRegex.Text);
        }

        #region hotkeys
        private void RegisterHotkeys() {
            HotkeyManager.Current.AddOrReplace(nameof(OnHotkeyNextStep), Keys.NumPad6, OnHotkeyNextStep);
            HotkeyManager.Current.AddOrReplace(nameof(OnHotkeyPrevStep), Keys.NumPad4, OnHotkeyPrevStep);
            HotkeyManager.Current.AddOrReplace(nameof(OnHotkeyCopyRegex), Keys.NumPad5, OnHotkeyCopyRegex);
        }

        private void OnHotkeyNextStep(object? sender, HotkeyEventArgs e) {
            NextStep();
        }
        private void OnHotkeyPrevStep(object? sender, HotkeyEventArgs e) {
            PrevStep();
        }
        private void OnHotkeyCopyRegex(object? sender, HotkeyEventArgs e) {
            CopyRegex();
        }

        private void RemoveHotkeys(object? sender, FormClosingEventArgs e) {
            HotkeyManager.Current.Remove(nameof(OnHotkeyNextStep));
            HotkeyManager.Current.Remove(nameof(OnHotkeyPrevStep));
            HotkeyManager.Current.Remove(nameof(OnHotkeyCopyRegex));
        }
        #endregion

        #region control events
        private void cbAlwaysOnTop_CheckedChanged(object sender, EventArgs e) {
            TopMost = cbAlwaysOnTop.Checked;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            _currentStep = cbStep.SelectedIndex;
            UpdateSteps();
        }
        private void numericFontSize_ValueChanged(object sender, EventArgs e) {
            label1.Font = lblRegex.Font = nextStepsBox.Font = stepsBox.Font = new Font(stepsBox.Font.FontFamily, (float)numericFontSize.Value);
        }
        private void btnNext_Click(object sender, EventArgs e) {
            NextStep();
        }

        private void btnPrev_Click(object sender, EventArgs e) {
            PrevStep();
        }
        private void btnCopyRegex_Click(object sender, EventArgs e) {
            CopyRegex();
        }
        #endregion



    }
}
