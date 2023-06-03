using System.ComponentModel;

namespace LanguageEditor.Views
{
    partial class RelationEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationEdit));
            this.labelNameInvalidMsg = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvFromArrow = new System.Windows.Forms.ListView();
            this.imglistFromArrows = new System.Windows.Forms.ImageList(this.components);
            this.lvStroke = new System.Windows.Forms.ListView();
            this.imglistStroke = new System.Windows.Forms.ImageList(this.components);
            this.lvToArrow = new System.Windows.Forms.ListView();
            this.imglistToArrows = new System.Windows.Forms.ImageList(this.components);
            this.labelFontInfo = new System.Windows.Forms.Label();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRelationText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddAttr = new System.Windows.Forms.Button();
            this.btnDelAttr = new System.Windows.Forms.Button();
            this.dgvAttrs = new System.Windows.Forms.DataGridView();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxSource = new System.Windows.Forms.ComboBox();
            this.cboxTarget = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttrs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameInvalidMsg
            // 
            this.labelNameInvalidMsg.AutoSize = true;
            this.labelNameInvalidMsg.ForeColor = System.Drawing.Color.Red;
            this.labelNameInvalidMsg.Location = new System.Drawing.Point(422, 37);
            this.labelNameInvalidMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameInvalidMsg.Name = "labelNameInvalidMsg";
            this.labelNameInvalidMsg.Size = new System.Drawing.Size(160, 17);
            this.labelNameInvalidMsg.TabIndex = 11;
            this.labelNameInvalidMsg.Text = "Это поле обязательно!";
            this.labelNameInvalidMsg.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(325, 9);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 22);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Внешний вид:";
            // 
            // lvFromArrow
            // 
            this.lvFromArrow.HideSelection = false;
            this.lvFromArrow.LargeImageList = this.imglistFromArrows;
            this.lvFromArrow.Location = new System.Drawing.Point(12, 160);
            this.lvFromArrow.MultiSelect = false;
            this.lvFromArrow.Name = "lvFromArrow";
            this.lvFromArrow.Size = new System.Drawing.Size(187, 332);
            this.lvFromArrow.TabIndex = 13;
            this.lvFromArrow.UseCompatibleStateImageBehavior = false;
            this.lvFromArrow.View = System.Windows.Forms.View.Tile;
            // 
            // imglistFromArrows
            // 
            this.imglistFromArrows.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistFromArrows.ImageStream")));
            this.imglistFromArrows.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistFromArrows.Images.SetKeyName(0, "default.png");
            this.imglistFromArrows.Images.SetKeyName(1, "fromOpenTriangle.png");
            this.imglistFromArrows.Images.SetKeyName(2, "fromStandard.png");
            this.imglistFromArrows.Images.SetKeyName(3, "fromStretchedDiamond.png");
            this.imglistFromArrows.Images.SetKeyName(4, "fromDoubleTriangle.png");
            this.imglistFromArrows.Images.SetKeyName(5, "fromLine.png");
            this.imglistFromArrows.Images.SetKeyName(6, "fromTwoLines.png");
            this.imglistFromArrows.Images.SetKeyName(7, "fromBackslash.png");
            this.imglistFromArrows.Images.SetKeyName(8, "fromX.png");
            this.imglistFromArrows.Images.SetKeyName(9, "fromOpenTriangleBackward.png");
            this.imglistFromArrows.Images.SetKeyName(10, "fromOpenTriangleBackwardLine.png");
            this.imglistFromArrows.Images.SetKeyName(11, "fromHalfCircle.png");
            this.imglistFromArrows.Images.SetKeyName(12, "fromPlusCircle.png");
            // 
            // lvStroke
            // 
            this.lvStroke.HideSelection = false;
            this.lvStroke.LargeImageList = this.imglistStroke;
            this.lvStroke.Location = new System.Drawing.Point(205, 160);
            this.lvStroke.MultiSelect = false;
            this.lvStroke.Name = "lvStroke";
            this.lvStroke.Size = new System.Drawing.Size(187, 332);
            this.lvStroke.TabIndex = 14;
            this.lvStroke.UseCompatibleStateImageBehavior = false;
            this.lvStroke.View = System.Windows.Forms.View.Tile;
            // 
            // imglistStroke
            // 
            this.imglistStroke.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistStroke.ImageStream")));
            this.imglistStroke.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistStroke.Images.SetKeyName(0, "solid.png");
            this.imglistStroke.Images.SetKeyName(1, "dashed.png");
            this.imglistStroke.Images.SetKeyName(2, "dotted.png");
            this.imglistStroke.Images.SetKeyName(3, "dotdash.png");
            // 
            // lvToArrow
            // 
            this.lvToArrow.HideSelection = false;
            this.lvToArrow.LargeImageList = this.imglistToArrows;
            this.lvToArrow.Location = new System.Drawing.Point(398, 160);
            this.lvToArrow.MultiSelect = false;
            this.lvToArrow.Name = "lvToArrow";
            this.lvToArrow.Size = new System.Drawing.Size(187, 332);
            this.lvToArrow.TabIndex = 15;
            this.lvToArrow.UseCompatibleStateImageBehavior = false;
            this.lvToArrow.View = System.Windows.Forms.View.Tile;
            // 
            // imglistToArrows
            // 
            this.imglistToArrows.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistToArrows.ImageStream")));
            this.imglistToArrows.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistToArrows.Images.SetKeyName(0, "default.png");
            this.imglistToArrows.Images.SetKeyName(1, "toOpenTriangle.png");
            this.imglistToArrows.Images.SetKeyName(2, "toStandard.png");
            this.imglistToArrows.Images.SetKeyName(3, "toStretchedDiamond.png");
            this.imglistToArrows.Images.SetKeyName(4, "toDoubleTriangle.png");
            this.imglistToArrows.Images.SetKeyName(5, "toLine.png");
            this.imglistToArrows.Images.SetKeyName(6, "toTwoLines.png");
            this.imglistToArrows.Images.SetKeyName(7, "toBackslash.png");
            this.imglistToArrows.Images.SetKeyName(8, "toX.png");
            this.imglistToArrows.Images.SetKeyName(9, "toOpenTriangleBackward.png");
            this.imglistToArrows.Images.SetKeyName(10, "toOpenTriangleBackwardLine.png");
            this.imglistToArrows.Images.SetKeyName(11, "toHalfCircle.png");
            this.imglistToArrows.Images.SetKeyName(12, "toPlusCircle.png");
            // 
            // labelFontInfo
            // 
            this.labelFontInfo.AutoSize = true;
            this.labelFontInfo.Location = new System.Drawing.Point(999, 62);
            this.labelFontInfo.Name = "labelFontInfo";
            this.labelFontInfo.Size = new System.Drawing.Size(55, 17);
            this.labelFontInfo.TabIndex = 38;
            this.labelFontInfo.Text = "fontinfo";
            // 
            // btnSetFont
            // 
            this.btnSetFont.Location = new System.Drawing.Point(872, 56);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(107, 28);
            this.btnSetFont.TabIndex = 37;
            this.btnSetFont.Text = "Настроить...";
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.btnSetFont_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(649, 62);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Шрифт:";
            // 
            // tbRelationText
            // 
            this.tbRelationText.Location = new System.Drawing.Point(872, 9);
            this.tbRelationText.Name = "tbRelationText";
            this.tbRelationText.Size = new System.Drawing.Size(407, 22);
            this.tbRelationText.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Текст связи:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(657, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Атрибуты:";
            // 
            // btnAddAttr
            // 
            this.btnAddAttr.Location = new System.Drawing.Point(1057, 500);
            this.btnAddAttr.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAttr.Name = "btnAddAttr";
            this.btnAddAttr.Size = new System.Drawing.Size(100, 28);
            this.btnAddAttr.TabIndex = 41;
            this.btnAddAttr.Text = "Добавить";
            this.btnAddAttr.UseVisualStyleBackColor = true;
            this.btnAddAttr.Click += new System.EventHandler(this.btnAddAttr_Click);
            // 
            // btnDelAttr
            // 
            this.btnDelAttr.Location = new System.Drawing.Point(1179, 500);
            this.btnDelAttr.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelAttr.Name = "btnDelAttr";
            this.btnDelAttr.Size = new System.Drawing.Size(100, 28);
            this.btnDelAttr.TabIndex = 40;
            this.btnDelAttr.Text = "Удалить";
            this.btnDelAttr.UseVisualStyleBackColor = true;
            this.btnDelAttr.Click += new System.EventHandler(this.btnDelAttr_Click);
            // 
            // dgvAttrs
            // 
            this.dgvAttrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttrs.Location = new System.Drawing.Point(657, 160);
            this.dgvAttrs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAttrs.Name = "dgvAttrs";
            this.dgvAttrs.RowHeadersWidth = 51;
            this.dgvAttrs.Size = new System.Drawing.Size(621, 332);
            this.dgvAttrs.TabIndex = 39;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Location = new System.Drawing.Point(64, 517);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(31, 29);
            this.panelColor.TabIndex = 45;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(101, 517);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(98, 29);
            this.btnSetColor.TabIndex = 44;
            this.btnSetColor.Text = "Настроить...";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Цвет:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1178, 610);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Источник*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Приемник*:";
            // 
            // cboxSource
            // 
            this.cboxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSource.FormattingEnabled = true;
            this.cboxSource.Location = new System.Drawing.Point(325, 59);
            this.cboxSource.Name = "cboxSource";
            this.cboxSource.Size = new System.Drawing.Size(257, 24);
            this.cboxSource.TabIndex = 49;
            this.cboxSource.SelectedIndexChanged += new System.EventHandler(this.cboxSource_SelectedIndexChanged);
            // 
            // cboxTarget
            // 
            this.cboxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTarget.FormattingEnabled = true;
            this.cboxTarget.Location = new System.Drawing.Point(325, 97);
            this.cboxTarget.Name = "cboxTarget";
            this.cboxTarget.Size = new System.Drawing.Size(257, 24);
            this.cboxTarget.TabIndex = 50;
            this.cboxTarget.SelectedIndexChanged += new System.EventHandler(this.cboxTarget_SelectedIndexChanged);
            // 
            // RelationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1291, 651);
            this.Controls.Add(this.cboxTarget);
            this.Controls.Add(this.cboxSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddAttr);
            this.Controls.Add(this.btnDelAttr);
            this.Controls.Add(this.dgvAttrs);
            this.Controls.Add(this.labelFontInfo);
            this.Controls.Add(this.btnSetFont);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbRelationText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lvToArrow);
            this.Controls.Add(this.lvStroke);
            this.Controls.Add(this.lvFromArrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNameInvalidMsg);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "RelationEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cboxSource;
        private System.Windows.Forms.ComboBox cboxTarget;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ImageList imglistStroke;
        private System.Windows.Forms.ImageList imglistToArrows;

        private System.Windows.Forms.ImageList imglistFromArrows;

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddAttr;
        private System.Windows.Forms.Button btnDelAttr;
        private System.Windows.Forms.DataGridView dgvAttrs;

        private System.Windows.Forms.Label labelFontInfo;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRelationText;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.ListView lvFromArrow;
        private System.Windows.Forms.ListView lvStroke;
        private System.Windows.Forms.ListView lvToArrow;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label labelNameInvalidMsg;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}