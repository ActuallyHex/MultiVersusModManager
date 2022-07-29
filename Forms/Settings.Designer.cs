
namespace BunifulInstall.Forms
{
    partial class Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtDirectory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAutoMakeFolder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.fileChooser = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAutoLaunchPath = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.AcceptsReturn = false;
            this.txtDirectory.AcceptsTab = false;
            this.txtDirectory.AnimationSpeed = 1;
            this.txtDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDirectory.BackColor = System.Drawing.Color.Transparent;
            this.txtDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDirectory.BackgroundImage")));
            this.txtDirectory.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDirectory.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDirectory.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDirectory.BorderColorIdle = System.Drawing.Color.Black;
            this.txtDirectory.BorderRadius = 1;
            this.txtDirectory.BorderThickness = 0;
            this.txtDirectory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirectory.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDirectory.DefaultText = "";
            this.txtDirectory.FillColor = System.Drawing.Color.Black;
            this.txtDirectory.ForeColor = System.Drawing.Color.White;
            this.txtDirectory.HideSelection = true;
            this.txtDirectory.IconLeft = null;
            this.txtDirectory.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirectory.IconPadding = 10;
            this.txtDirectory.IconRight = null;
            this.txtDirectory.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirectory.Lines = new string[0];
            this.txtDirectory.Location = new System.Drawing.Point(13, 49);
            this.txtDirectory.MaxLength = 32767;
            this.txtDirectory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDirectory.Modified = false;
            this.txtDirectory.Multiline = false;
            this.txtDirectory.Name = "txtDirectory";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDirectory.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDirectory.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDirectory.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.Black;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDirectory.OnIdleState = stateProperties4;
            this.txtDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.txtDirectory.PasswordChar = '\0';
            this.txtDirectory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDirectory.PlaceholderText = "Enter text";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDirectory.SelectedText = "";
            this.txtDirectory.SelectionLength = 0;
            this.txtDirectory.SelectionStart = 0;
            this.txtDirectory.ShortcutsEnabled = true;
            this.txtDirectory.Size = new System.Drawing.Size(652, 37);
            this.txtDirectory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDirectory.TextMarginBottom = 0;
            this.txtDirectory.TextMarginLeft = 3;
            this.txtDirectory.TextMarginTop = 0;
            this.txtDirectory.TextPlaceholder = "Enter text";
            this.txtDirectory.UseSystemPasswordChar = false;
            this.txtDirectory.WordWrap = true;
            // 
            // btnAutoMakeFolder
            // 
            this.btnAutoMakeFolder.AllowAnimations = true;
            this.btnAutoMakeFolder.AllowMouseEffects = true;
            this.btnAutoMakeFolder.AllowToggling = false;
            this.btnAutoMakeFolder.AnimationSpeed = 1;
            this.btnAutoMakeFolder.AutoGenerateColors = false;
            this.btnAutoMakeFolder.AutoRoundBorders = false;
            this.btnAutoMakeFolder.AutoSizeLeftIcon = false;
            this.btnAutoMakeFolder.AutoSizeRightIcon = false;
            this.btnAutoMakeFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoMakeFolder.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAutoMakeFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoMakeFolder.BackgroundImage")));
            this.btnAutoMakeFolder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoMakeFolder.ButtonText = "           Auto Find/Make Mod Folder";
            this.btnAutoMakeFolder.ButtonTextMarginLeft = 0;
            this.btnAutoMakeFolder.ColorContrastOnClick = 45;
            this.btnAutoMakeFolder.ColorContrastOnHover = 45;
            this.btnAutoMakeFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAutoMakeFolder.CustomizableEdges = borderEdges1;
            this.btnAutoMakeFolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAutoMakeFolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAutoMakeFolder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAutoMakeFolder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAutoMakeFolder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnAutoMakeFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoMakeFolder.ForeColor = System.Drawing.Color.White;
            this.btnAutoMakeFolder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoMakeFolder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAutoMakeFolder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAutoMakeFolder.IconMarginLeft = 11;
            this.btnAutoMakeFolder.IconPadding = 0;
            this.btnAutoMakeFolder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutoMakeFolder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAutoMakeFolder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAutoMakeFolder.IconSize = 35;
            this.btnAutoMakeFolder.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAutoMakeFolder.IdleBorderRadius = 1;
            this.btnAutoMakeFolder.IdleBorderThickness = 1;
            this.btnAutoMakeFolder.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAutoMakeFolder.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAutoMakeFolder.IdleIconLeftImage")));
            this.btnAutoMakeFolder.IdleIconRightImage = null;
            this.btnAutoMakeFolder.IndicateFocus = false;
            this.btnAutoMakeFolder.Location = new System.Drawing.Point(13, 92);
            this.btnAutoMakeFolder.Name = "btnAutoMakeFolder";
            this.btnAutoMakeFolder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAutoMakeFolder.OnDisabledState.BorderRadius = 1;
            this.btnAutoMakeFolder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoMakeFolder.OnDisabledState.BorderThickness = 1;
            this.btnAutoMakeFolder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAutoMakeFolder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAutoMakeFolder.OnDisabledState.IconLeftImage = null;
            this.btnAutoMakeFolder.OnDisabledState.IconRightImage = null;
            this.btnAutoMakeFolder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoMakeFolder.onHoverState.BorderRadius = 1;
            this.btnAutoMakeFolder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoMakeFolder.onHoverState.BorderThickness = 1;
            this.btnAutoMakeFolder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoMakeFolder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAutoMakeFolder.onHoverState.IconLeftImage = null;
            this.btnAutoMakeFolder.onHoverState.IconRightImage = null;
            this.btnAutoMakeFolder.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAutoMakeFolder.OnIdleState.BorderRadius = 1;
            this.btnAutoMakeFolder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoMakeFolder.OnIdleState.BorderThickness = 1;
            this.btnAutoMakeFolder.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAutoMakeFolder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAutoMakeFolder.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAutoMakeFolder.OnIdleState.IconLeftImage")));
            this.btnAutoMakeFolder.OnIdleState.IconRightImage = null;
            this.btnAutoMakeFolder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoMakeFolder.OnPressedState.BorderRadius = 1;
            this.btnAutoMakeFolder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoMakeFolder.OnPressedState.BorderThickness = 1;
            this.btnAutoMakeFolder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoMakeFolder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAutoMakeFolder.OnPressedState.IconLeftImage = null;
            this.btnAutoMakeFolder.OnPressedState.IconRightImage = null;
            this.btnAutoMakeFolder.Size = new System.Drawing.Size(281, 39);
            this.btnAutoMakeFolder.TabIndex = 4;
            this.btnAutoMakeFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutoMakeFolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAutoMakeFolder.TextMarginLeft = 0;
            this.btnAutoMakeFolder.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAutoMakeFolder.UseDefaultRadiusAndThickness = true;
            this.btnAutoMakeFolder.Click += new System.EventHandler(this.btnAutoMakeFolder_Click);
            // 
            // fileChooser
            // 
            this.fileChooser.AllowAnimations = true;
            this.fileChooser.AllowMouseEffects = true;
            this.fileChooser.AllowToggling = false;
            this.fileChooser.AnimationSpeed = 1;
            this.fileChooser.AutoGenerateColors = false;
            this.fileChooser.AutoRoundBorders = false;
            this.fileChooser.AutoSizeLeftIcon = false;
            this.fileChooser.AutoSizeRightIcon = false;
            this.fileChooser.BackColor = System.Drawing.Color.Transparent;
            this.fileChooser.BackColor1 = System.Drawing.Color.Transparent;
            this.fileChooser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileChooser.BackgroundImage")));
            this.fileChooser.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileChooser.ButtonText = "             Manually Choose Mod Folder";
            this.fileChooser.ButtonTextMarginLeft = 0;
            this.fileChooser.ColorContrastOnClick = 45;
            this.fileChooser.ColorContrastOnHover = 45;
            this.fileChooser.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.fileChooser.CustomizableEdges = borderEdges2;
            this.fileChooser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fileChooser.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.fileChooser.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fileChooser.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.fileChooser.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.fileChooser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileChooser.ForeColor = System.Drawing.Color.White;
            this.fileChooser.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileChooser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.fileChooser.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.fileChooser.IconMarginLeft = 11;
            this.fileChooser.IconPadding = 0;
            this.fileChooser.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileChooser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.fileChooser.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.fileChooser.IconSize = 35;
            this.fileChooser.IdleBorderColor = System.Drawing.Color.Transparent;
            this.fileChooser.IdleBorderRadius = 1;
            this.fileChooser.IdleBorderThickness = 1;
            this.fileChooser.IdleFillColor = System.Drawing.Color.Transparent;
            this.fileChooser.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("fileChooser.IdleIconLeftImage")));
            this.fileChooser.IdleIconRightImage = null;
            this.fileChooser.IndicateFocus = false;
            this.fileChooser.Location = new System.Drawing.Point(13, 137);
            this.fileChooser.Name = "fileChooser";
            this.fileChooser.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.fileChooser.OnDisabledState.BorderRadius = 1;
            this.fileChooser.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileChooser.OnDisabledState.BorderThickness = 1;
            this.fileChooser.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fileChooser.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.fileChooser.OnDisabledState.IconLeftImage = null;
            this.fileChooser.OnDisabledState.IconRightImage = null;
            this.fileChooser.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fileChooser.onHoverState.BorderRadius = 1;
            this.fileChooser.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileChooser.onHoverState.BorderThickness = 1;
            this.fileChooser.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fileChooser.onHoverState.ForeColor = System.Drawing.Color.White;
            this.fileChooser.onHoverState.IconLeftImage = null;
            this.fileChooser.onHoverState.IconRightImage = null;
            this.fileChooser.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.fileChooser.OnIdleState.BorderRadius = 1;
            this.fileChooser.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileChooser.OnIdleState.BorderThickness = 1;
            this.fileChooser.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.fileChooser.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.fileChooser.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.OnIdleState.IconLeftImage")));
            this.fileChooser.OnIdleState.IconRightImage = null;
            this.fileChooser.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fileChooser.OnPressedState.BorderRadius = 1;
            this.fileChooser.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileChooser.OnPressedState.BorderThickness = 1;
            this.fileChooser.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fileChooser.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.fileChooser.OnPressedState.IconLeftImage = null;
            this.fileChooser.OnPressedState.IconRightImage = null;
            this.fileChooser.Size = new System.Drawing.Size(281, 39);
            this.fileChooser.TabIndex = 5;
            this.fileChooser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileChooser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileChooser.TextMarginLeft = 0;
            this.fileChooser.TextPadding = new System.Windows.Forms.Padding(0);
            this.fileChooser.UseDefaultRadiusAndThickness = true;
            this.fileChooser.Click += new System.EventHandler(this.fileChooser_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(13, 18);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(116, 25);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Mod File Path";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(13, 233);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(475, 25);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "Please choose the content folder in your game directory.";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(13, 264);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(516, 25);
            this.bunifuLabel3.TabIndex = 8;
            this.bunifuLabel3.Text = "The mods folder will be auto created if there isnt one already.";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAutoLaunchPath
            // 
            this.btnAutoLaunchPath.AllowAnimations = true;
            this.btnAutoLaunchPath.AllowMouseEffects = true;
            this.btnAutoLaunchPath.AllowToggling = false;
            this.btnAutoLaunchPath.AnimationSpeed = 1;
            this.btnAutoLaunchPath.AutoGenerateColors = false;
            this.btnAutoLaunchPath.AutoRoundBorders = false;
            this.btnAutoLaunchPath.AutoSizeLeftIcon = false;
            this.btnAutoLaunchPath.AutoSizeRightIcon = false;
            this.btnAutoLaunchPath.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoLaunchPath.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAutoLaunchPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoLaunchPath.BackgroundImage")));
            this.btnAutoLaunchPath.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoLaunchPath.ButtonText = "      Quick Launch Game Path";
            this.btnAutoLaunchPath.ButtonTextMarginLeft = 0;
            this.btnAutoLaunchPath.ColorContrastOnClick = 45;
            this.btnAutoLaunchPath.ColorContrastOnHover = 45;
            this.btnAutoLaunchPath.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAutoLaunchPath.CustomizableEdges = borderEdges3;
            this.btnAutoLaunchPath.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAutoLaunchPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAutoLaunchPath.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAutoLaunchPath.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAutoLaunchPath.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnAutoLaunchPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoLaunchPath.ForeColor = System.Drawing.Color.White;
            this.btnAutoLaunchPath.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoLaunchPath.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAutoLaunchPath.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAutoLaunchPath.IconMarginLeft = 11;
            this.btnAutoLaunchPath.IconPadding = 0;
            this.btnAutoLaunchPath.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutoLaunchPath.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAutoLaunchPath.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAutoLaunchPath.IconSize = 35;
            this.btnAutoLaunchPath.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAutoLaunchPath.IdleBorderRadius = 1;
            this.btnAutoLaunchPath.IdleBorderThickness = 1;
            this.btnAutoLaunchPath.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAutoLaunchPath.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAutoLaunchPath.IdleIconLeftImage")));
            this.btnAutoLaunchPath.IdleIconRightImage = null;
            this.btnAutoLaunchPath.IndicateFocus = false;
            this.btnAutoLaunchPath.Location = new System.Drawing.Point(13, 182);
            this.btnAutoLaunchPath.Name = "btnAutoLaunchPath";
            this.btnAutoLaunchPath.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAutoLaunchPath.OnDisabledState.BorderRadius = 1;
            this.btnAutoLaunchPath.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoLaunchPath.OnDisabledState.BorderThickness = 1;
            this.btnAutoLaunchPath.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAutoLaunchPath.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAutoLaunchPath.OnDisabledState.IconLeftImage = null;
            this.btnAutoLaunchPath.OnDisabledState.IconRightImage = null;
            this.btnAutoLaunchPath.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoLaunchPath.onHoverState.BorderRadius = 1;
            this.btnAutoLaunchPath.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoLaunchPath.onHoverState.BorderThickness = 1;
            this.btnAutoLaunchPath.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoLaunchPath.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAutoLaunchPath.onHoverState.IconLeftImage = null;
            this.btnAutoLaunchPath.onHoverState.IconRightImage = null;
            this.btnAutoLaunchPath.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAutoLaunchPath.OnIdleState.BorderRadius = 1;
            this.btnAutoLaunchPath.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoLaunchPath.OnIdleState.BorderThickness = 1;
            this.btnAutoLaunchPath.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAutoLaunchPath.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAutoLaunchPath.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.OnIdleState.IconLeftImage1")));
            this.btnAutoLaunchPath.OnIdleState.IconRightImage = null;
            this.btnAutoLaunchPath.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoLaunchPath.OnPressedState.BorderRadius = 1;
            this.btnAutoLaunchPath.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAutoLaunchPath.OnPressedState.BorderThickness = 1;
            this.btnAutoLaunchPath.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAutoLaunchPath.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAutoLaunchPath.OnPressedState.IconLeftImage = null;
            this.btnAutoLaunchPath.OnPressedState.IconRightImage = null;
            this.btnAutoLaunchPath.Size = new System.Drawing.Size(281, 39);
            this.btnAutoLaunchPath.TabIndex = 9;
            this.btnAutoLaunchPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutoLaunchPath.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAutoLaunchPath.TextMarginLeft = 0;
            this.btnAutoLaunchPath.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAutoLaunchPath.UseDefaultRadiusAndThickness = true;
            this.btnAutoLaunchPath.Click += new System.EventHandler(this.btnAutoLaunchPath_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAutoLaunchPath);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.fileChooser);
            this.Controls.Add(this.btnAutoMakeFolder);
            this.Controls.Add(this.txtDirectory);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(823, 641);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtDirectory;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAutoMakeFolder;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton fileChooser;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAutoLaunchPath;
    }
}
