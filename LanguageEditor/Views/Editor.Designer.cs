namespace LanguageEditor.Views
{
    partial class Editor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.diagramControl = new Northwoods.Go.WinForms.DiagramControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonScale = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemScale25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScale50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScale75 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScale100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScale125 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScale150 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScale200 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScale300 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonUpscale = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDownScale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripScaleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewControl = new Northwoods.Go.WinForms.OverviewControl();
            this.buttonAddEntity = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramControl
            // 
            this.diagramControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagramControl.BackColor = System.Drawing.Color.White;
            this.diagramControl.Location = new System.Drawing.Point(196, 28);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.Size = new System.Drawing.Size(611, 569);
            this.diagramControl.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonScale,
            this.toolStripButtonUpscale,
            this.toolStripButtonDownScale,
            this.toolStripSeparator1,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonScale
            // 
            this.toolStripDropDownButtonScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemScale25,
            this.toolStripMenuItemScale50,
            this.toolStripMenuItemScale75,
            this.toolStripMenuItemScale100,
            this.toolStripMenuItemScale125,
            this.toolStripMenuItemScale150,
            this.toolStripMenuItemScale200,
            this.toolStripMenuItemScale300});
            this.toolStripDropDownButtonScale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonScale.Image")));
            this.toolStripDropDownButtonScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonScale.Name = "toolStripDropDownButtonScale";
            this.toolStripDropDownButtonScale.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButtonScale.Text = "Масштаб";
            // 
            // toolStripMenuItemScale25
            // 
            this.toolStripMenuItemScale25.Name = "toolStripMenuItemScale25";
            this.toolStripMenuItemScale25.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale25.Text = "25%";
            this.toolStripMenuItemScale25.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItemScale50
            // 
            this.toolStripMenuItemScale50.Name = "toolStripMenuItemScale50";
            this.toolStripMenuItemScale50.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale50.Text = "50%";
            this.toolStripMenuItemScale50.Click += new System.EventHandler(this.toolStripMenuItemScale50_Click);
            // 
            // toolStripMenuItemScale75
            // 
            this.toolStripMenuItemScale75.Name = "toolStripMenuItemScale75";
            this.toolStripMenuItemScale75.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale75.Text = "75%";
            this.toolStripMenuItemScale75.Click += new System.EventHandler(this.toolStripMenuItemScale75_Click);
            // 
            // toolStripMenuItemScale100
            // 
            this.toolStripMenuItemScale100.Name = "toolStripMenuItemScale100";
            this.toolStripMenuItemScale100.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale100.Text = "100%";
            this.toolStripMenuItemScale100.Click += new System.EventHandler(this.toolStripMenuItemScale100_Click);
            // 
            // toolStripMenuItemScale125
            // 
            this.toolStripMenuItemScale125.Name = "toolStripMenuItemScale125";
            this.toolStripMenuItemScale125.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale125.Text = "125%";
            this.toolStripMenuItemScale125.Click += new System.EventHandler(this.toolStripMenuItemScale125_Click);
            // 
            // toolStripMenuItemScale150
            // 
            this.toolStripMenuItemScale150.Name = "toolStripMenuItemScale150";
            this.toolStripMenuItemScale150.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale150.Text = "150%";
            this.toolStripMenuItemScale150.Click += new System.EventHandler(this.toolStripMenuItemScale150_Click);
            // 
            // toolStripMenuItemScale200
            // 
            this.toolStripMenuItemScale200.Name = "toolStripMenuItemScale200";
            this.toolStripMenuItemScale200.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale200.Text = "200%";
            this.toolStripMenuItemScale200.Click += new System.EventHandler(this.toolStripMenuItemScale200_Click);
            // 
            // toolStripMenuItemScale300
            // 
            this.toolStripMenuItemScale300.Name = "toolStripMenuItemScale300";
            this.toolStripMenuItemScale300.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItemScale300.Text = "300%";
            this.toolStripMenuItemScale300.Click += new System.EventHandler(this.toolStripMenuItemScale300_Click);
            // 
            // toolStripButtonUpscale
            // 
            this.toolStripButtonUpscale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpscale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpscale.Image")));
            this.toolStripButtonUpscale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpscale.Name = "toolStripButtonUpscale";
            this.toolStripButtonUpscale.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpscale.Text = "Увеличить (Alt + Mousewheel)";
            this.toolStripButtonUpscale.Click += new System.EventHandler(this.toolStripButtonUpscale_Click);
            // 
            // toolStripButtonDownScale
            // 
            this.toolStripButtonDownScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDownScale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDownScale.Image")));
            this.toolStripButtonDownScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownScale.Name = "toolStripButtonDownScale";
            this.toolStripButtonDownScale.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDownScale.Text = "Уменьшить (Alt + Mousewheel)";
            this.toolStripButtonDownScale.Click += new System.EventHandler(this.toolStripButtonDownScale_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "Отменить (Ctrl + Z)";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRedo.Text = "Вернуть (Ctrl + Y)";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripScaleLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripScaleLabel
            // 
            this.toolStripScaleLabel.Name = "toolStripScaleLabel";
            this.toolStripScaleLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripScaleLabel.Text = "toolStripStatusLabel1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.переименоватьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сеткаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // сеткаToolStripMenuItem
            // 
            this.сеткаToolStripMenuItem.Name = "сеткаToolStripMenuItem";
            this.сеткаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.сеткаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.сеткаToolStripMenuItem.Text = "Сетка";
            this.сеткаToolStripMenuItem.Click += new System.EventHandler(this.сеткаToolStripMenuItem_Click);
            // 
            // overviewControl
            // 
            this.overviewControl.BackColor = System.Drawing.Color.White;
            this.overviewControl.Location = new System.Drawing.Point(12, 52);
            this.overviewControl.Name = "overviewControl";
            this.overviewControl.Size = new System.Drawing.Size(178, 178);
            this.overviewControl.TabIndex = 4;
            // 
            // buttonAddEntity
            // 
            this.buttonAddEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEntity.AutoSize = true;
            this.buttonAddEntity.Location = new System.Drawing.Point(831, 52);
            this.buttonAddEntity.Name = "buttonAddEntity";
            this.buttonAddEntity.Size = new System.Drawing.Size(169, 23);
            this.buttonAddEntity.TabIndex = 5;
            this.buttonAddEntity.Text = "+ Новая сущность";
            this.buttonAddEntity.UseVisualStyleBackColor = true;
            this.buttonAddEntity.Click += new System.EventHandler(this.buttonAddEntity_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 622);
            this.Controls.Add(this.buttonAddEntity);
            this.Controls.Add(this.overviewControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.diagramControl);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Northwoods.Go.WinForms.DiagramControl diagramControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonScale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale125;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale150;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale200;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale300;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale75;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripScaleLabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpscale;
        private System.Windows.Forms.ToolStripButton toolStripButtonDownScale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеткаToolStripMenuItem;
        private Northwoods.Go.WinForms.OverviewControl overviewControl;
        private System.Windows.Forms.Button buttonAddEntity;
    }
}