namespace MoeGoe_GUI
{
    partial class MainWin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.EXEPanel = new System.Windows.Forms.GroupBox();
            this.EXEPath = new System.Windows.Forms.TextBox();
            this.openEXE = new System.Windows.Forms.Button();
            this.modelPanel = new System.Windows.Forms.GroupBox();
            this.configPath = new System.Windows.Forms.TextBox();
            this.openConfig = new System.Windows.Forms.Button();
            this.modelPath = new System.Windows.Forms.TextBox();
            this.openModel = new System.Windows.Forms.Button();
            this.modeControl = new System.Windows.Forms.TabControl();
            this.TTSPage = new System.Windows.Forms.TabPage();
            this.speakerBox = new System.Windows.Forms.ComboBox();
            this.speakerLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cleanButton = new System.Windows.Forms.ToolStripMenuItem();
            this.paramsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VCPage = new System.Windows.Forms.TabPage();
            this.openOrigin = new System.Windows.Forms.Button();
            this.originPath = new System.Windows.Forms.TextBox();
            this.originBox = new System.Windows.Forms.ComboBox();
            this.originLabel = new System.Windows.Forms.Label();
            this.targetBox = new System.Windows.Forms.ComboBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.GroupBox();
            this.saveDirectlyButton = new System.Windows.Forms.Button();
            this.savePath = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.modelControl = new System.Windows.Forms.TabControl();
            this.vitsPage = new System.Windows.Forms.TabPage();
            this.hubertPage = new System.Windows.Forms.TabPage();
            this.HVCPanel = new System.Windows.Forms.GroupBox();
            this.HAdvancedControl = new System.Windows.Forms.Button();
            this.HOpenOrigin = new System.Windows.Forms.Button();
            this.HOriginPath = new System.Windows.Forms.TextBox();
            this.HTargetBox = new System.Windows.Forms.ComboBox();
            this.HTargetLabel = new System.Windows.Forms.Label();
            this.HModelPanel = new System.Windows.Forms.GroupBox();
            this.hubertPath = new System.Windows.Forms.TextBox();
            this.HOpenHubert = new System.Windows.Forms.Button();
            this.HConfigPath = new System.Windows.Forms.TextBox();
            this.HOpenConfig = new System.Windows.Forms.Button();
            this.HModelPath = new System.Windows.Forms.TextBox();
            this.HOpenModel = new System.Windows.Forms.Button();
            this.EXEPanel.SuspendLayout();
            this.modelPanel.SuspendLayout();
            this.modeControl.SuspendLayout();
            this.TTSPage.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.VCPage.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.modelControl.SuspendLayout();
            this.vitsPage.SuspendLayout();
            this.hubertPage.SuspendLayout();
            this.HVCPanel.SuspendLayout();
            this.HModelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EXEPanel
            // 
            this.EXEPanel.Controls.Add(this.EXEPath);
            this.EXEPanel.Controls.Add(this.openEXE);
            this.EXEPanel.Location = new System.Drawing.Point(8, 8);
            this.EXEPanel.Margin = new System.Windows.Forms.Padding(2);
            this.EXEPanel.Name = "EXEPanel";
            this.EXEPanel.Padding = new System.Windows.Forms.Padding(2);
            this.EXEPanel.Size = new System.Drawing.Size(334, 57);
            this.EXEPanel.TabIndex = 0;
            this.EXEPanel.TabStop = false;
            this.EXEPanel.Text = "MoeGoe.exe";
            // 
            // EXEPath
            // 
            this.EXEPath.Location = new System.Drawing.Point(88, 21);
            this.EXEPath.Margin = new System.Windows.Forms.Padding(2);
            this.EXEPath.Name = "EXEPath";
            this.EXEPath.Size = new System.Drawing.Size(243, 23);
            this.EXEPath.TabIndex = 1;
            this.EXEPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EXEPath_KeyDown);
            this.EXEPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EXEPath_KeyPress);
            // 
            // openEXE
            // 
            this.openEXE.Location = new System.Drawing.Point(4, 20);
            this.openEXE.Margin = new System.Windows.Forms.Padding(2);
            this.openEXE.Name = "openEXE";
            this.openEXE.Size = new System.Drawing.Size(80, 23);
            this.openEXE.TabIndex = 0;
            this.openEXE.Text = "打开文件";
            this.openEXE.UseVisualStyleBackColor = true;
            this.openEXE.Click += new System.EventHandler(this.OpenEXE_Click);
            // 
            // modelPanel
            // 
            this.modelPanel.Controls.Add(this.configPath);
            this.modelPanel.Controls.Add(this.openConfig);
            this.modelPanel.Controls.Add(this.modelPath);
            this.modelPanel.Controls.Add(this.openModel);
            this.modelPanel.Location = new System.Drawing.Point(4, 4);
            this.modelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Padding = new System.Windows.Forms.Padding(2);
            this.modelPanel.Size = new System.Drawing.Size(323, 83);
            this.modelPanel.TabIndex = 1;
            this.modelPanel.TabStop = false;
            this.modelPanel.Text = "模型文件";
            // 
            // configPath
            // 
            this.configPath.Location = new System.Drawing.Point(88, 49);
            this.configPath.Margin = new System.Windows.Forms.Padding(2);
            this.configPath.Name = "configPath";
            this.configPath.Size = new System.Drawing.Size(233, 23);
            this.configPath.TabIndex = 3;
            this.configPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigPath_KeyDown);
            this.configPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfigPath_KeyPress);
            // 
            // openConfig
            // 
            this.openConfig.Location = new System.Drawing.Point(4, 47);
            this.openConfig.Margin = new System.Windows.Forms.Padding(2);
            this.openConfig.Name = "openConfig";
            this.openConfig.Size = new System.Drawing.Size(80, 23);
            this.openConfig.TabIndex = 2;
            this.openConfig.Text = "打开配置";
            this.openConfig.UseVisualStyleBackColor = true;
            this.openConfig.Click += new System.EventHandler(this.OpenConfig_Click);
            // 
            // modelPath
            // 
            this.modelPath.Location = new System.Drawing.Point(88, 21);
            this.modelPath.Margin = new System.Windows.Forms.Padding(2);
            this.modelPath.Name = "modelPath";
            this.modelPath.Size = new System.Drawing.Size(233, 23);
            this.modelPath.TabIndex = 1;
            this.modelPath.TextChanged += new System.EventHandler(this.modelPath_TextChanged);
            this.modelPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModelPath_KeyDown);
            this.modelPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelPath_KeyPress);
            // 
            // openModel
            // 
            this.openModel.Location = new System.Drawing.Point(4, 20);
            this.openModel.Margin = new System.Windows.Forms.Padding(2);
            this.openModel.Name = "openModel";
            this.openModel.Size = new System.Drawing.Size(80, 23);
            this.openModel.TabIndex = 0;
            this.openModel.Text = "打开模型";
            this.openModel.UseVisualStyleBackColor = true;
            this.openModel.Click += new System.EventHandler(this.OpenModel_Click);
            // 
            // modeControl
            // 
            this.modeControl.Controls.Add(this.TTSPage);
            this.modeControl.Controls.Add(this.VCPage);
            this.modeControl.Enabled = false;
            this.modeControl.Location = new System.Drawing.Point(4, 91);
            this.modeControl.Margin = new System.Windows.Forms.Padding(2);
            this.modeControl.Name = "modeControl";
            this.modeControl.SelectedIndex = 0;
            this.modeControl.Size = new System.Drawing.Size(325, 126);
            this.modeControl.TabIndex = 2;
            // 
            // TTSPage
            // 
            this.TTSPage.Controls.Add(this.speakerBox);
            this.TTSPage.Controls.Add(this.speakerLabel);
            this.TTSPage.Controls.Add(this.textLabel);
            this.TTSPage.Controls.Add(this.textBox);
            this.TTSPage.Location = new System.Drawing.Point(4, 26);
            this.TTSPage.Margin = new System.Windows.Forms.Padding(2);
            this.TTSPage.Name = "TTSPage";
            this.TTSPage.Padding = new System.Windows.Forms.Padding(2);
            this.TTSPage.Size = new System.Drawing.Size(317, 96);
            this.TTSPage.TabIndex = 0;
            this.TTSPage.Text = "语音合成";
            this.TTSPage.UseVisualStyleBackColor = true;
            // 
            // speakerBox
            // 
            this.speakerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speakerBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.speakerBox.FormattingEnabled = true;
            this.speakerBox.Location = new System.Drawing.Point(86, 73);
            this.speakerBox.Margin = new System.Windows.Forms.Padding(2);
            this.speakerBox.Name = "speakerBox";
            this.speakerBox.Size = new System.Drawing.Size(231, 23);
            this.speakerBox.TabIndex = 3;
            // 
            // speakerLabel
            // 
            this.speakerLabel.AutoSize = true;
            this.speakerLabel.Location = new System.Drawing.Point(23, 75);
            this.speakerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speakerLabel.Name = "speakerLabel";
            this.speakerLabel.Size = new System.Drawing.Size(44, 17);
            this.speakerLabel.TabIndex = 2;
            this.speakerLabel.Text = "说话人";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(29, 29);
            this.textLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(32, 17);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "文本";
            // 
            // textBox
            // 
            this.textBox.ContextMenuStrip = this.menuStrip;
            this.textBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox.Location = new System.Drawing.Point(86, 7);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(231, 63);
            this.textBox.TabIndex = 1;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanButton,
            this.paramsButton,
            this.symbolsButton});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(125, 70);
            // 
            // cleanButton
            // 
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(124, 22);
            this.cleanButton.Text = "清理文本";
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // paramsButton
            // 
            this.paramsButton.Name = "paramsButton";
            this.paramsButton.Size = new System.Drawing.Size(124, 22);
            this.paramsButton.Text = "参数设置";
            this.paramsButton.Click += new System.EventHandler(this.AdvancedButton_Click);
            // 
            // symbolsButton
            // 
            this.symbolsButton.Name = "symbolsButton";
            this.symbolsButton.Size = new System.Drawing.Size(124, 22);
            this.symbolsButton.Text = "符号输入";
            this.symbolsButton.Click += new System.EventHandler(this.SymbolsButton_Click);
            // 
            // VCPage
            // 
            this.VCPage.Controls.Add(this.openOrigin);
            this.VCPage.Controls.Add(this.originPath);
            this.VCPage.Controls.Add(this.originBox);
            this.VCPage.Controls.Add(this.originLabel);
            this.VCPage.Controls.Add(this.targetBox);
            this.VCPage.Controls.Add(this.targetLabel);
            this.VCPage.Location = new System.Drawing.Point(4, 26);
            this.VCPage.Margin = new System.Windows.Forms.Padding(2);
            this.VCPage.Name = "VCPage";
            this.VCPage.Padding = new System.Windows.Forms.Padding(2);
            this.VCPage.Size = new System.Drawing.Size(317, 96);
            this.VCPage.TabIndex = 1;
            this.VCPage.Text = "语音转换";
            this.VCPage.UseVisualStyleBackColor = true;
            // 
            // openOrigin
            // 
            this.openOrigin.Location = new System.Drawing.Point(8, 5);
            this.openOrigin.Margin = new System.Windows.Forms.Padding(2);
            this.openOrigin.Name = "openOrigin";
            this.openOrigin.Size = new System.Drawing.Size(72, 23);
            this.openOrigin.TabIndex = 4;
            this.openOrigin.Text = "打开原音频";
            this.openOrigin.UseVisualStyleBackColor = true;
            this.openOrigin.Click += new System.EventHandler(this.OpenOrigin_Click);
            // 
            // originPath
            // 
            this.originPath.Location = new System.Drawing.Point(85, 7);
            this.originPath.Margin = new System.Windows.Forms.Padding(2);
            this.originPath.Name = "originPath";
            this.originPath.Size = new System.Drawing.Size(231, 23);
            this.originPath.TabIndex = 12;
            this.originPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OriginPath_KeyPress);
            // 
            // originBox
            // 
            this.originBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.originBox.FormattingEnabled = true;
            this.originBox.Location = new System.Drawing.Point(85, 47);
            this.originBox.Margin = new System.Windows.Forms.Padding(2);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(231, 23);
            this.originBox.TabIndex = 10;
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(17, 50);
            this.originLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(56, 17);
            this.originLabel.TabIndex = 9;
            this.originLabel.Text = "原说话人";
            // 
            // targetBox
            // 
            this.targetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.targetBox.FormattingEnabled = true;
            this.targetBox.Location = new System.Drawing.Point(85, 73);
            this.targetBox.Margin = new System.Windows.Forms.Padding(2);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(231, 23);
            this.targetBox.TabIndex = 8;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(11, 75);
            this.targetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(68, 17);
            this.targetLabel.TabIndex = 7;
            this.targetLabel.Text = "目标说话人";
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.saveDirectlyButton);
            this.savePanel.Controls.Add(this.savePath);
            this.savePanel.Controls.Add(this.playButton);
            this.savePanel.Controls.Add(this.saveButton);
            this.savePanel.Enabled = false;
            this.savePanel.Location = new System.Drawing.Point(8, 324);
            this.savePanel.Margin = new System.Windows.Forms.Padding(2);
            this.savePanel.Name = "savePanel";
            this.savePanel.Padding = new System.Windows.Forms.Padding(2);
            this.savePanel.Size = new System.Drawing.Size(334, 100);
            this.savePanel.TabIndex = 3;
            this.savePanel.TabStop = false;
            this.savePanel.Text = "保存文件";
            // 
            // saveDirectlyButton
            // 
            this.saveDirectlyButton.Location = new System.Drawing.Point(4, 60);
            this.saveDirectlyButton.Name = "saveDirectlyButton";
            this.saveDirectlyButton.Size = new System.Drawing.Size(80, 23);
            this.saveDirectlyButton.TabIndex = 7;
            this.saveDirectlyButton.Text = "快速保存";
            this.saveDirectlyButton.UseVisualStyleBackColor = true;
            this.saveDirectlyButton.Click += new System.EventHandler(this.saveDirectlyButton_Click);
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(88, 21);
            this.savePath.Margin = new System.Windows.Forms.Padding(2);
            this.savePath.Name = "savePath";
            this.savePath.ReadOnly = true;
            this.savePath.Size = new System.Drawing.Size(243, 23);
            this.savePath.TabIndex = 1;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(90, 60);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(80, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "播放";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(4, 20);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "保存结果";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.consoleBox.Location = new System.Drawing.Point(352, 16);
            this.consoleBox.Margin = new System.Windows.Forms.Padding(2);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(292, 408);
            this.consoleBox.TabIndex = 4;
            // 
            // modelControl
            // 
            this.modelControl.Controls.Add(this.vitsPage);
            this.modelControl.Controls.Add(this.hubertPage);
            this.modelControl.Enabled = false;
            this.modelControl.Location = new System.Drawing.Point(8, 69);
            this.modelControl.Margin = new System.Windows.Forms.Padding(2);
            this.modelControl.Name = "modelControl";
            this.modelControl.SelectedIndex = 0;
            this.modelControl.Size = new System.Drawing.Size(337, 251);
            this.modelControl.TabIndex = 5;
            this.modelControl.SelectedIndexChanged += new System.EventHandler(this.ModelControl_SelectedIndexChanged);
            // 
            // vitsPage
            // 
            this.vitsPage.Controls.Add(this.modelPanel);
            this.vitsPage.Controls.Add(this.modeControl);
            this.vitsPage.Location = new System.Drawing.Point(4, 26);
            this.vitsPage.Margin = new System.Windows.Forms.Padding(2);
            this.vitsPage.Name = "vitsPage";
            this.vitsPage.Padding = new System.Windows.Forms.Padding(2);
            this.vitsPage.Size = new System.Drawing.Size(329, 221);
            this.vitsPage.TabIndex = 0;
            this.vitsPage.Text = "VITS";
            this.vitsPage.UseVisualStyleBackColor = true;
            // 
            // hubertPage
            // 
            this.hubertPage.Controls.Add(this.HVCPanel);
            this.hubertPage.Controls.Add(this.HModelPanel);
            this.hubertPage.Location = new System.Drawing.Point(4, 26);
            this.hubertPage.Margin = new System.Windows.Forms.Padding(2);
            this.hubertPage.Name = "hubertPage";
            this.hubertPage.Padding = new System.Windows.Forms.Padding(2);
            this.hubertPage.Size = new System.Drawing.Size(329, 221);
            this.hubertPage.TabIndex = 1;
            this.hubertPage.Text = "HuBERT-VITS";
            this.hubertPage.UseVisualStyleBackColor = true;
            // 
            // HVCPanel
            // 
            this.HVCPanel.Controls.Add(this.HAdvancedControl);
            this.HVCPanel.Controls.Add(this.HOpenOrigin);
            this.HVCPanel.Controls.Add(this.HOriginPath);
            this.HVCPanel.Controls.Add(this.HTargetBox);
            this.HVCPanel.Controls.Add(this.HTargetLabel);
            this.HVCPanel.Enabled = false;
            this.HVCPanel.Location = new System.Drawing.Point(4, 119);
            this.HVCPanel.Margin = new System.Windows.Forms.Padding(2);
            this.HVCPanel.Name = "HVCPanel";
            this.HVCPanel.Padding = new System.Windows.Forms.Padding(2);
            this.HVCPanel.Size = new System.Drawing.Size(323, 97);
            this.HVCPanel.TabIndex = 3;
            this.HVCPanel.TabStop = false;
            this.HVCPanel.Text = "语音转换";
            // 
            // HAdvancedControl
            // 
            this.HAdvancedControl.Location = new System.Drawing.Point(247, 61);
            this.HAdvancedControl.Margin = new System.Windows.Forms.Padding(2);
            this.HAdvancedControl.Name = "HAdvancedControl";
            this.HAdvancedControl.Size = new System.Drawing.Size(73, 23);
            this.HAdvancedControl.TabIndex = 17;
            this.HAdvancedControl.Text = "高级设置";
            this.HAdvancedControl.UseVisualStyleBackColor = true;
            this.HAdvancedControl.Click += new System.EventHandler(this.HAdvancedControl_Click);
            // 
            // HOpenOrigin
            // 
            this.HOpenOrigin.Location = new System.Drawing.Point(4, 20);
            this.HOpenOrigin.Margin = new System.Windows.Forms.Padding(2);
            this.HOpenOrigin.Name = "HOpenOrigin";
            this.HOpenOrigin.Size = new System.Drawing.Size(80, 23);
            this.HOpenOrigin.TabIndex = 13;
            this.HOpenOrigin.Text = "打开原音频";
            this.HOpenOrigin.UseVisualStyleBackColor = true;
            this.HOpenOrigin.Click += new System.EventHandler(this.HOpenOrigin_Click);
            // 
            // HOriginPath
            // 
            this.HOriginPath.Location = new System.Drawing.Point(88, 21);
            this.HOriginPath.Margin = new System.Windows.Forms.Padding(2);
            this.HOriginPath.Name = "HOriginPath";
            this.HOriginPath.Size = new System.Drawing.Size(233, 23);
            this.HOriginPath.TabIndex = 16;
            this.HOriginPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HOriginPath_KeyPress);
            // 
            // HTargetBox
            // 
            this.HTargetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HTargetBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HTargetBox.FormattingEnabled = true;
            this.HTargetBox.Location = new System.Drawing.Point(88, 61);
            this.HTargetBox.Margin = new System.Windows.Forms.Padding(2);
            this.HTargetBox.Name = "HTargetBox";
            this.HTargetBox.Size = new System.Drawing.Size(156, 23);
            this.HTargetBox.TabIndex = 15;
            // 
            // HTargetLabel
            // 
            this.HTargetLabel.AutoSize = true;
            this.HTargetLabel.Location = new System.Drawing.Point(11, 64);
            this.HTargetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HTargetLabel.Name = "HTargetLabel";
            this.HTargetLabel.Size = new System.Drawing.Size(68, 17);
            this.HTargetLabel.TabIndex = 14;
            this.HTargetLabel.Text = "目标说话人";
            // 
            // HModelPanel
            // 
            this.HModelPanel.Controls.Add(this.hubertPath);
            this.HModelPanel.Controls.Add(this.HOpenHubert);
            this.HModelPanel.Controls.Add(this.HConfigPath);
            this.HModelPanel.Controls.Add(this.HOpenConfig);
            this.HModelPanel.Controls.Add(this.HModelPath);
            this.HModelPanel.Controls.Add(this.HOpenModel);
            this.HModelPanel.Location = new System.Drawing.Point(4, 4);
            this.HModelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.HModelPanel.Name = "HModelPanel";
            this.HModelPanel.Padding = new System.Windows.Forms.Padding(2);
            this.HModelPanel.Size = new System.Drawing.Size(323, 111);
            this.HModelPanel.TabIndex = 2;
            this.HModelPanel.TabStop = false;
            this.HModelPanel.Text = "模型文件";
            // 
            // hubertPath
            // 
            this.hubertPath.Location = new System.Drawing.Point(88, 76);
            this.hubertPath.Margin = new System.Windows.Forms.Padding(2);
            this.hubertPath.Name = "hubertPath";
            this.hubertPath.Size = new System.Drawing.Size(233, 23);
            this.hubertPath.TabIndex = 5;
            this.hubertPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HubertPath_KeyDown);
            this.hubertPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HubertPath_KeyPress);
            // 
            // HOpenHubert
            // 
            this.HOpenHubert.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HOpenHubert.Location = new System.Drawing.Point(4, 75);
            this.HOpenHubert.Margin = new System.Windows.Forms.Padding(2);
            this.HOpenHubert.Name = "HOpenHubert";
            this.HOpenHubert.Size = new System.Drawing.Size(80, 23);
            this.HOpenHubert.TabIndex = 4;
            this.HOpenHubert.Text = "HuBERT模型";
            this.HOpenHubert.UseVisualStyleBackColor = true;
            this.HOpenHubert.Click += new System.EventHandler(this.HOpenHubert_Click);
            // 
            // HConfigPath
            // 
            this.HConfigPath.Location = new System.Drawing.Point(88, 49);
            this.HConfigPath.Margin = new System.Windows.Forms.Padding(2);
            this.HConfigPath.Name = "HConfigPath";
            this.HConfigPath.Size = new System.Drawing.Size(233, 23);
            this.HConfigPath.TabIndex = 3;
            this.HConfigPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HConfigPath_KeyDown);
            this.HConfigPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HConfigPath_KeyPress);
            // 
            // HOpenConfig
            // 
            this.HOpenConfig.Location = new System.Drawing.Point(4, 47);
            this.HOpenConfig.Margin = new System.Windows.Forms.Padding(2);
            this.HOpenConfig.Name = "HOpenConfig";
            this.HOpenConfig.Size = new System.Drawing.Size(80, 23);
            this.HOpenConfig.TabIndex = 2;
            this.HOpenConfig.Text = "VITS配置";
            this.HOpenConfig.UseVisualStyleBackColor = true;
            this.HOpenConfig.Click += new System.EventHandler(this.HOpenConfig_Click);
            // 
            // HModelPath
            // 
            this.HModelPath.Location = new System.Drawing.Point(88, 21);
            this.HModelPath.Margin = new System.Windows.Forms.Padding(2);
            this.HModelPath.Name = "HModelPath";
            this.HModelPath.Size = new System.Drawing.Size(233, 23);
            this.HModelPath.TabIndex = 1;
            this.HModelPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HModelPath_KeyDown);
            this.HModelPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HModelPath_KeyPress);
            // 
            // HOpenModel
            // 
            this.HOpenModel.Location = new System.Drawing.Point(4, 20);
            this.HOpenModel.Margin = new System.Windows.Forms.Padding(2);
            this.HOpenModel.Name = "HOpenModel";
            this.HOpenModel.Size = new System.Drawing.Size(80, 23);
            this.HOpenModel.TabIndex = 0;
            this.HOpenModel.Text = "VITS模型";
            this.HOpenModel.UseVisualStyleBackColor = true;
            this.HOpenModel.Click += new System.EventHandler(this.HOpenModel_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.modelControl);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.EXEPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoeGoe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.EXEPanel.ResumeLayout(false);
            this.EXEPanel.PerformLayout();
            this.modelPanel.ResumeLayout(false);
            this.modelPanel.PerformLayout();
            this.modeControl.ResumeLayout(false);
            this.TTSPage.ResumeLayout(false);
            this.TTSPage.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.VCPage.ResumeLayout(false);
            this.VCPage.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.modelControl.ResumeLayout(false);
            this.vitsPage.ResumeLayout(false);
            this.hubertPage.ResumeLayout(false);
            this.HVCPanel.ResumeLayout(false);
            this.HVCPanel.PerformLayout();
            this.HModelPanel.ResumeLayout(false);
            this.HModelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EXEPanel;
        private System.Windows.Forms.TextBox EXEPath;
        private System.Windows.Forms.Button openEXE;
        private System.Windows.Forms.GroupBox modelPanel;
        private System.Windows.Forms.TextBox configPath;
        private System.Windows.Forms.Button openConfig;
        private System.Windows.Forms.TextBox modelPath;
        private System.Windows.Forms.Button openModel;
        private System.Windows.Forms.TabControl modeControl;
        private System.Windows.Forms.TabPage TTSPage;
        private System.Windows.Forms.TabPage VCPage;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox speakerBox;
        private System.Windows.Forms.Label speakerLabel;
        private System.Windows.Forms.TextBox originPath;
        private System.Windows.Forms.ComboBox originBox;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.ComboBox targetBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.GroupBox savePanel;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Button openOrigin;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cleanButton;
        private System.Windows.Forms.ToolStripMenuItem paramsButton;
        private System.Windows.Forms.TabControl modelControl;
        private System.Windows.Forms.TabPage vitsPage;
        private System.Windows.Forms.TabPage hubertPage;
        private System.Windows.Forms.GroupBox HVCPanel;
        private System.Windows.Forms.GroupBox HModelPanel;
        private System.Windows.Forms.TextBox hubertPath;
        private System.Windows.Forms.Button HOpenHubert;
        private System.Windows.Forms.TextBox HConfigPath;
        private System.Windows.Forms.Button HOpenConfig;
        private System.Windows.Forms.TextBox HModelPath;
        private System.Windows.Forms.Button HOpenModel;
        private System.Windows.Forms.Button HOpenOrigin;
        private System.Windows.Forms.TextBox HOriginPath;
        private System.Windows.Forms.ComboBox HTargetBox;
        private System.Windows.Forms.Label HTargetLabel;
        private System.Windows.Forms.Button HAdvancedControl;
        private System.Windows.Forms.ToolStripMenuItem symbolsButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button saveDirectlyButton;
    }
}

