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
            this.components = new System.ComponentModel.Container();
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
            this.buttonAddEntity = new System.Windows.Forms.Button();
            this.overviewControl = new Northwoods.Go.WinForms.OverviewControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paletteControl1 = new Northwoods.Go.WinForms.PaletteControl();
            this.dgrSelectedElemData = new System.Windows.Forms.DataGridView();
            this.btnViewAttributes = new System.Windows.Forms.Button();
            this.btnViewProps = new System.Windows.Forms.Button();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSelectedElemData)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl
            // 
            this.diagramControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.diagramControl.BackColor = System.Drawing.Color.White;
            this.diagramControl.Location = new System.Drawing.Point(310, 59);
            this.diagramControl.Margin = new System.Windows.Forms.Padding(4);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.Size = new System.Drawing.Size(1039, 779);
            this.diagramControl.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripDropDownButtonScale, this.toolStripButtonUpscale, this.toolStripButtonDownScale, this.toolStripSeparator1, this.toolStripButtonUndo, this.toolStripButtonRedo });
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1349, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonScale
            // 
            this.toolStripDropDownButtonScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItemScale25, this.toolStripMenuItemScale50, this.toolStripMenuItemScale75, this.toolStripMenuItemScale100, this.toolStripMenuItemScale125, this.toolStripMenuItemScale150, this.toolStripMenuItemScale200, this.toolStripMenuItemScale300 });
            this.toolStripDropDownButtonScale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonScale.Image")));
            this.toolStripDropDownButtonScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonScale.Name = "toolStripDropDownButtonScale";
            this.toolStripDropDownButtonScale.Size = new System.Drawing.Size(85, 24);
            this.toolStripDropDownButtonScale.Text = "Масштаб";
            // 
            // toolStripMenuItemScale25
            // 
            this.toolStripMenuItemScale25.Name = "toolStripMenuItemScale25";
            this.toolStripMenuItemScale25.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale25.Text = "25%";
            this.toolStripMenuItemScale25.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItemScale50
            // 
            this.toolStripMenuItemScale50.Name = "toolStripMenuItemScale50";
            this.toolStripMenuItemScale50.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale50.Text = "50%";
            this.toolStripMenuItemScale50.Click += new System.EventHandler(this.toolStripMenuItemScale50_Click);
            // 
            // toolStripMenuItemScale75
            // 
            this.toolStripMenuItemScale75.Name = "toolStripMenuItemScale75";
            this.toolStripMenuItemScale75.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale75.Text = "75%";
            this.toolStripMenuItemScale75.Click += new System.EventHandler(this.toolStripMenuItemScale75_Click);
            // 
            // toolStripMenuItemScale100
            // 
            this.toolStripMenuItemScale100.Name = "toolStripMenuItemScale100";
            this.toolStripMenuItemScale100.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale100.Text = "100%";
            this.toolStripMenuItemScale100.Click += new System.EventHandler(this.toolStripMenuItemScale100_Click);
            // 
            // toolStripMenuItemScale125
            // 
            this.toolStripMenuItemScale125.Name = "toolStripMenuItemScale125";
            this.toolStripMenuItemScale125.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale125.Text = "125%";
            this.toolStripMenuItemScale125.Click += new System.EventHandler(this.toolStripMenuItemScale125_Click);
            // 
            // toolStripMenuItemScale150
            // 
            this.toolStripMenuItemScale150.Name = "toolStripMenuItemScale150";
            this.toolStripMenuItemScale150.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale150.Text = "150%";
            this.toolStripMenuItemScale150.Click += new System.EventHandler(this.toolStripMenuItemScale150_Click);
            // 
            // toolStripMenuItemScale200
            // 
            this.toolStripMenuItemScale200.Name = "toolStripMenuItemScale200";
            this.toolStripMenuItemScale200.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale200.Text = "200%";
            this.toolStripMenuItemScale200.Click += new System.EventHandler(this.toolStripMenuItemScale200_Click);
            // 
            // toolStripMenuItemScale300
            // 
            this.toolStripMenuItemScale300.Name = "toolStripMenuItemScale300";
            this.toolStripMenuItemScale300.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItemScale300.Text = "300%";
            this.toolStripMenuItemScale300.Click += new System.EventHandler(this.toolStripMenuItemScale300_Click);
            // 
            // toolStripButtonUpscale
            // 
            this.toolStripButtonUpscale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpscale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpscale.Image")));
            this.toolStripButtonUpscale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpscale.Name = "toolStripButtonUpscale";
            this.toolStripButtonUpscale.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonUpscale.Text = "Увеличить (Alt + Mousewheel)";
            this.toolStripButtonUpscale.Click += new System.EventHandler(this.toolStripButtonUpscale_Click);
            // 
            // toolStripButtonDownScale
            // 
            this.toolStripButtonDownScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDownScale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDownScale.Image")));
            this.toolStripButtonDownScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownScale.Name = "toolStripButtonDownScale";
            this.toolStripButtonDownScale.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDownScale.Text = "Уменьшить (Alt + Mousewheel)";
            this.toolStripButtonDownScale.Click += new System.EventHandler(this.toolStripButtonDownScale_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonUndo.Text = "Отменить (Ctrl + Z)";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRedo.Text = "Вернуть (Ctrl + Y)";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripScaleLabel });
            this.statusStrip.Location = new System.Drawing.Point(0, 813);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1349, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripScaleLabel
            // 
            this.toolStripScaleLabel.Name = "toolStripScaleLabel";
            this.toolStripScaleLabel.Size = new System.Drawing.Size(151, 20);
            this.toolStripScaleLabel.Text = "toolStripStatusLabel1";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.файлToolStripMenuItem, this.видToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1349, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.сохранитьToolStripMenuItem, this.переименоватьToolStripMenuItem });
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.сеткаToolStripMenuItem });
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // сеткаToolStripMenuItem
            // 
            this.сеткаToolStripMenuItem.Name = "сеткаToolStripMenuItem";
            this.сеткаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.G)));
            this.сеткаToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.сеткаToolStripMenuItem.Text = "Сетка";
            this.сеткаToolStripMenuItem.Click += new System.EventHandler(this.сеткаToolStripMenuItem_Click);
            // 
            // buttonAddEntity
            // 
            this.buttonAddEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddEntity.AutoSize = true;
            this.buttonAddEntity.Location = new System.Drawing.Point(141, 385);
            this.buttonAddEntity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddEntity.Name = "buttonAddEntity";
            this.buttonAddEntity.Size = new System.Drawing.Size(133, 28);
            this.buttonAddEntity.TabIndex = 5;
            this.buttonAddEntity.Text = "+ Новая вершина";
            this.buttonAddEntity.UseVisualStyleBackColor = true;
            this.buttonAddEntity.Click += new System.EventHandler(this.buttonAddEntity_Click);
            // 
            // overviewControl
            // 
            this.overviewControl.BackColor = System.Drawing.Color.White;
            this.overviewControl.Location = new System.Drawing.Point(0, 59);
            this.overviewControl.Margin = new System.Windows.Forms.Padding(4);
            this.overviewControl.Name = "overviewControl";
            this.overviewControl.Size = new System.Drawing.Size(302, 173);
            this.overviewControl.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // paletteControl1
            // 
            this.paletteControl1.BackColor = System.Drawing.Color.White;
            this.paletteControl1.Location = new System.Drawing.Point(0, 239);
            this.paletteControl1.Name = "paletteControl1";
            this.paletteControl1.Size = new System.Drawing.Size(302, 129);
            this.paletteControl1.TabIndex = 6;
            this.paletteControl1.Text = "paletteControl1";
            // 
            // dgrSelectedElemData
            // 
            this.dgrSelectedElemData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgrSelectedElemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSelectedElemData.Location = new System.Drawing.Point(0, 590);
            this.dgrSelectedElemData.Name = "dgrSelectedElemData";
            this.dgrSelectedElemData.RowTemplate.Height = 24;
            this.dgrSelectedElemData.Size = new System.Drawing.Size(302, 220);
            this.dgrSelectedElemData.TabIndex = 7;
            // 
            // btnViewAttributes
            // 
            this.btnViewAttributes.Location = new System.Drawing.Point(216, 552);
            this.btnViewAttributes.Name = "btnViewAttributes";
            this.btnViewAttributes.Size = new System.Drawing.Size(86, 32);
            this.btnViewAttributes.TabIndex = 8;
            this.btnViewAttributes.Text = "Атрибуты";
            this.btnViewAttributes.UseVisualStyleBackColor = true;
            this.btnViewAttributes.Click += new System.EventHandler(this.btnViewAttributes_Click);
            // 
            // btnViewProps
            // 
            this.btnViewProps.Location = new System.Drawing.Point(124, 552);
            this.btnViewProps.Name = "btnViewProps";
            this.btnViewProps.Size = new System.Drawing.Size(86, 32);
            this.btnViewProps.TabIndex = 9;
            this.btnViewProps.Text = "Свойства";
            this.btnViewProps.UseVisualStyleBackColor = true;
            this.btnViewProps.Click += new System.EventHandler(this.btnViewProps_Click);
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRelation.AutoSize = true;
            this.btnAddRelation.Location = new System.Drawing.Point(0, 385);
            this.btnAddRelation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(133, 28);
            this.btnAddRelation.TabIndex = 10;
            this.btnAddRelation.Text = "+ Новая связь";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 838);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.btnViewProps);
            this.Controls.Add(this.btnViewAttributes);
            this.Controls.Add(this.dgrSelectedElemData);
            this.Controls.Add(this.paletteControl1);
            this.Controls.Add(this.overviewControl);
            this.Controls.Add(this.buttonAddEntity);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.diagramControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSelectedElemData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAddRelation;

        private System.Windows.Forms.Button btnViewAttributes;
        private System.Windows.Forms.Button btnViewProps;

        private System.Windows.Forms.DataGridView dgrSelectedElemData;

        private Northwoods.Go.WinForms.PaletteControl paletteControl1;

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
        private System.Windows.Forms.Button buttonAddEntity;
        private Northwoods.Go.WinForms.OverviewControl overviewControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}