
namespace BunifulInstall.Forms
{
    partial class InstalledMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstalledMods));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lstMods = new System.Windows.Forms.ListBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnRefreshList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDisable = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEnable = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // lstMods
            // 
            this.lstMods.BackColor = System.Drawing.Color.Black;
            this.lstMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMods.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMods.ForeColor = System.Drawing.Color.White;
            this.lstMods.FormattingEnabled = true;
            this.lstMods.IntegralHeight = false;
            this.lstMods.ItemHeight = 20;
            this.lstMods.Items.AddRange(new object[] {
            "No mod"});
            this.lstMods.Location = new System.Drawing.Point(24, 30);
            this.lstMods.MultiColumn = true;
            this.lstMods.Name = "lstMods";
            this.lstMods.Size = new System.Drawing.Size(712, 300);
            this.lstMods.Sorted = true;
            this.lstMods.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(24, -1);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(123, 25);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Installed Mods";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.AllowAnimations = true;
            this.btnRefreshList.AllowMouseEffects = true;
            this.btnRefreshList.AllowToggling = false;
            this.btnRefreshList.AnimationSpeed = 1;
            this.btnRefreshList.AutoGenerateColors = false;
            this.btnRefreshList.AutoRoundBorders = false;
            this.btnRefreshList.AutoSizeLeftIcon = false;
            this.btnRefreshList.AutoSizeRightIcon = false;
            this.btnRefreshList.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshList.BackColor1 = System.Drawing.Color.Transparent;
            this.btnRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshList.BackgroundImage")));
            this.btnRefreshList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshList.ButtonText = "Refresh Mod List";
            this.btnRefreshList.ButtonTextMarginLeft = 0;
            this.btnRefreshList.ColorContrastOnClick = 45;
            this.btnRefreshList.ColorContrastOnHover = 45;
            this.btnRefreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRefreshList.CustomizableEdges = borderEdges1;
            this.btnRefreshList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefreshList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefreshList.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefreshList.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefreshList.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.ForeColor = System.Drawing.Color.White;
            this.btnRefreshList.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshList.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefreshList.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRefreshList.IconMarginLeft = 11;
            this.btnRefreshList.IconPadding = 0;
            this.btnRefreshList.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshList.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefreshList.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRefreshList.IconSize = 35;
            this.btnRefreshList.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnRefreshList.IdleBorderRadius = 1;
            this.btnRefreshList.IdleBorderThickness = 1;
            this.btnRefreshList.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnRefreshList.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshList.IdleIconLeftImage")));
            this.btnRefreshList.IdleIconRightImage = null;
            this.btnRefreshList.IndicateFocus = false;
            this.btnRefreshList.Location = new System.Drawing.Point(24, 336);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefreshList.OnDisabledState.BorderRadius = 1;
            this.btnRefreshList.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshList.OnDisabledState.BorderThickness = 1;
            this.btnRefreshList.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefreshList.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefreshList.OnDisabledState.IconLeftImage = null;
            this.btnRefreshList.OnDisabledState.IconRightImage = null;
            this.btnRefreshList.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnRefreshList.onHoverState.BorderRadius = 1;
            this.btnRefreshList.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshList.onHoverState.BorderThickness = 1;
            this.btnRefreshList.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnRefreshList.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefreshList.onHoverState.IconLeftImage = null;
            this.btnRefreshList.onHoverState.IconRightImage = null;
            this.btnRefreshList.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefreshList.OnIdleState.BorderRadius = 1;
            this.btnRefreshList.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshList.OnIdleState.BorderThickness = 1;
            this.btnRefreshList.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnRefreshList.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRefreshList.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshList.OnIdleState.IconLeftImage")));
            this.btnRefreshList.OnIdleState.IconRightImage = null;
            this.btnRefreshList.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnRefreshList.OnPressedState.BorderRadius = 1;
            this.btnRefreshList.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshList.OnPressedState.BorderThickness = 1;
            this.btnRefreshList.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnRefreshList.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRefreshList.OnPressedState.IconLeftImage = null;
            this.btnRefreshList.OnPressedState.IconRightImage = null;
            this.btnRefreshList.Size = new System.Drawing.Size(233, 39);
            this.btnRefreshList.TabIndex = 2;
            this.btnRefreshList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefreshList.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefreshList.TextMarginLeft = 0;
            this.btnRefreshList.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefreshList.UseDefaultRadiusAndThickness = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.AllowAnimations = true;
            this.btnDisable.AllowMouseEffects = true;
            this.btnDisable.AllowToggling = false;
            this.btnDisable.AnimationSpeed = 1;
            this.btnDisable.AutoGenerateColors = false;
            this.btnDisable.AutoRoundBorders = false;
            this.btnDisable.AutoSizeLeftIcon = false;
            this.btnDisable.AutoSizeRightIcon = false;
            this.btnDisable.BackColor = System.Drawing.Color.Transparent;
            this.btnDisable.BackColor1 = System.Drawing.Color.Transparent;
            this.btnDisable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisable.BackgroundImage")));
            this.btnDisable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDisable.ButtonText = "          Disable Selected Mods";
            this.btnDisable.ButtonTextMarginLeft = 0;
            this.btnDisable.ColorContrastOnClick = 45;
            this.btnDisable.ColorContrastOnHover = 45;
            this.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDisable.CustomizableEdges = borderEdges2;
            this.btnDisable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDisable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisable.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDisable.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDisable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnDisable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisable.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDisable.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDisable.IconMarginLeft = 11;
            this.btnDisable.IconPadding = 0;
            this.btnDisable.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisable.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDisable.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDisable.IconSize = 35;
            this.btnDisable.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnDisable.IdleBorderRadius = 1;
            this.btnDisable.IdleBorderThickness = 1;
            this.btnDisable.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDisable.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDisable.IdleIconLeftImage")));
            this.btnDisable.IdleIconRightImage = null;
            this.btnDisable.IndicateFocus = false;
            this.btnDisable.Location = new System.Drawing.Point(24, 426);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisable.OnDisabledState.BorderRadius = 1;
            this.btnDisable.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDisable.OnDisabledState.BorderThickness = 1;
            this.btnDisable.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDisable.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDisable.OnDisabledState.IconLeftImage = null;
            this.btnDisable.OnDisabledState.IconRightImage = null;
            this.btnDisable.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDisable.onHoverState.BorderRadius = 1;
            this.btnDisable.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDisable.onHoverState.BorderThickness = 1;
            this.btnDisable.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDisable.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDisable.onHoverState.IconLeftImage = null;
            this.btnDisable.onHoverState.IconRightImage = null;
            this.btnDisable.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDisable.OnIdleState.BorderRadius = 1;
            this.btnDisable.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDisable.OnIdleState.BorderThickness = 1;
            this.btnDisable.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnDisable.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDisable.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDisable.OnIdleState.IconLeftImage")));
            this.btnDisable.OnIdleState.IconRightImage = null;
            this.btnDisable.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDisable.OnPressedState.BorderRadius = 1;
            this.btnDisable.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDisable.OnPressedState.BorderThickness = 1;
            this.btnDisable.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnDisable.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDisable.OnPressedState.IconLeftImage = null;
            this.btnDisable.OnPressedState.IconRightImage = null;
            this.btnDisable.Size = new System.Drawing.Size(233, 39);
            this.btnDisable.TabIndex = 3;
            this.btnDisable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDisable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDisable.TextMarginLeft = 0;
            this.btnDisable.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDisable.UseDefaultRadiusAndThickness = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.AllowAnimations = true;
            this.btnEnable.AllowMouseEffects = true;
            this.btnEnable.AllowToggling = false;
            this.btnEnable.AnimationSpeed = 1;
            this.btnEnable.AutoGenerateColors = false;
            this.btnEnable.AutoRoundBorders = false;
            this.btnEnable.AutoSizeLeftIcon = false;
            this.btnEnable.AutoSizeRightIcon = false;
            this.btnEnable.BackColor = System.Drawing.Color.Transparent;
            this.btnEnable.BackColor1 = System.Drawing.Color.Transparent;
            this.btnEnable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnable.BackgroundImage")));
            this.btnEnable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnable.ButtonText = "          Enable Selected Mods";
            this.btnEnable.ButtonTextMarginLeft = 0;
            this.btnEnable.ColorContrastOnClick = 45;
            this.btnEnable.ColorContrastOnHover = 45;
            this.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnEnable.CustomizableEdges = borderEdges3;
            this.btnEnable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnable.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnable.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnEnable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnable.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEnable.IconMarginLeft = 11;
            this.btnEnable.IconPadding = 0;
            this.btnEnable.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnable.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnable.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEnable.IconSize = 35;
            this.btnEnable.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnEnable.IdleBorderRadius = 1;
            this.btnEnable.IdleBorderThickness = 1;
            this.btnEnable.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEnable.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnEnable.IdleIconLeftImage")));
            this.btnEnable.IdleIconRightImage = null;
            this.btnEnable.IndicateFocus = false;
            this.btnEnable.Location = new System.Drawing.Point(24, 381);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnable.OnDisabledState.BorderRadius = 1;
            this.btnEnable.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnable.OnDisabledState.BorderThickness = 1;
            this.btnEnable.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnable.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnable.OnDisabledState.IconLeftImage = null;
            this.btnEnable.OnDisabledState.IconRightImage = null;
            this.btnEnable.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnEnable.onHoverState.BorderRadius = 1;
            this.btnEnable.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnable.onHoverState.BorderThickness = 1;
            this.btnEnable.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnEnable.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEnable.onHoverState.IconLeftImage = null;
            this.btnEnable.onHoverState.IconRightImage = null;
            this.btnEnable.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEnable.OnIdleState.BorderRadius = 1;
            this.btnEnable.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnable.OnIdleState.BorderThickness = 1;
            this.btnEnable.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnEnable.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEnable.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnEnable.OnIdleState.IconLeftImage")));
            this.btnEnable.OnIdleState.IconRightImage = null;
            this.btnEnable.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnEnable.OnPressedState.BorderRadius = 1;
            this.btnEnable.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnable.OnPressedState.BorderThickness = 1;
            this.btnEnable.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnEnable.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEnable.OnPressedState.IconLeftImage = null;
            this.btnEnable.OnPressedState.IconRightImage = null;
            this.btnEnable.Size = new System.Drawing.Size(233, 39);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnable.TextMarginLeft = 0;
            this.btnEnable.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEnable.UseDefaultRadiusAndThickness = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // InstalledMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.lstMods);
            this.Name = "InstalledMods";
            this.Size = new System.Drawing.Size(823, 641);
            this.Load += new System.EventHandler(this.InstalledMods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMods;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefreshList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDisable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEnable;
    }
}
