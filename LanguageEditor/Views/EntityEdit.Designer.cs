namespace LanguageEditor.Views
{
    partial class EntityEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIsAbstract = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNameInvalidMsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCanSetMaxCount = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteAttribute = new System.Windows.Forms.Button();
            this.buttonAddAttribute = new System.Windows.Forms.Button();
            this.listViewShape = new System.Windows.Forms.ListView();
            this.imageListShapes = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFillColorDialog = new System.Windows.Forms.Button();
            this.buttonBorderColorDialog = new System.Windows.Forms.Button();
            this.panelFillColor = new System.Windows.Forms.Panel();
            this.panelStrokeColor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSetImage = new System.Windows.Forms.Button();
            this.labelImgPath = new System.Windows.Forms.Label();
            this.checkBoxImage = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEntityText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSetFont = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.labelFontInfo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAncestor = new System.Windows.Forms.Label();
            this.btnSetAncestor = new System.Windows.Forms.Button();
            this.btnDropAncestor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Абстрактная:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Макс. число экземпляров:";
            // 
            // numericUpDownMaxCount
            // 
            this.numericUpDownMaxCount.Location = new System.Drawing.Point(328, 135);
            this.numericUpDownMaxCount.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMaxCount.Name = "numericUpDownMaxCount";
            this.numericUpDownMaxCount.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownMaxCount.TabIndex = 3;
            // 
            // checkBoxIsAbstract
            // 
            this.checkBoxIsAbstract.AutoSize = true;
            this.checkBoxIsAbstract.Location = new System.Drawing.Point(328, 54);
            this.checkBoxIsAbstract.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIsAbstract.Name = "checkBoxIsAbstract";
            this.checkBoxIsAbstract.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsAbstract.TabIndex = 4;
            this.checkBoxIsAbstract.UseVisualStyleBackColor = true;
            this.checkBoxIsAbstract.CheckedChanged += new System.EventHandler(this.checkBoxIsAbstract_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(328, 15);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 22);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelNameInvalidMsg
            // 
            this.labelNameInvalidMsg.AutoSize = true;
            this.labelNameInvalidMsg.ForeColor = System.Drawing.Color.Red;
            this.labelNameInvalidMsg.Location = new System.Drawing.Point(425, 43);
            this.labelNameInvalidMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameInvalidMsg.Name = "labelNameInvalidMsg";
            this.labelNameInvalidMsg.Size = new System.Drawing.Size(160, 17);
            this.labelNameInvalidMsg.TabIndex = 6;
            this.labelNameInvalidMsg.Text = "Это поле обязательно!";
            this.labelNameInvalidMsg.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ограничить макс. число экземпляров";
            // 
            // checkBoxCanSetMaxCount
            // 
            this.checkBoxCanSetMaxCount.AutoSize = true;
            this.checkBoxCanSetMaxCount.Location = new System.Drawing.Point(328, 90);
            this.checkBoxCanSetMaxCount.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCanSetMaxCount.Name = "checkBoxCanSetMaxCount";
            this.checkBoxCanSetMaxCount.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCanSetMaxCount.TabIndex = 8;
            this.checkBoxCanSetMaxCount.UseVisualStyleBackColor = true;
            this.checkBoxCanSetMaxCount.CheckedChanged += new System.EventHandler(this.checkBoxCanSetMaxCount_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1178, 610);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(658, 213);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(621, 279);
            this.dataGridView.TabIndex = 10;
            // 
            // buttonDeleteAttribute
            // 
            this.buttonDeleteAttribute.Location = new System.Drawing.Point(1178, 500);
            this.buttonDeleteAttribute.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteAttribute.Name = "buttonDeleteAttribute";
            this.buttonDeleteAttribute.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteAttribute.TabIndex = 11;
            this.buttonDeleteAttribute.Text = "Удалить";
            this.buttonDeleteAttribute.UseVisualStyleBackColor = true;
            this.buttonDeleteAttribute.Click += new System.EventHandler(this.buttonDeleteAttribute_Click);
            // 
            // buttonAddAttribute
            // 
            this.buttonAddAttribute.Location = new System.Drawing.Point(1061, 500);
            this.buttonAddAttribute.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAttribute.Name = "buttonAddAttribute";
            this.buttonAddAttribute.Size = new System.Drawing.Size(100, 28);
            this.buttonAddAttribute.TabIndex = 12;
            this.buttonAddAttribute.Text = "Добавить";
            this.buttonAddAttribute.UseVisualStyleBackColor = true;
            this.buttonAddAttribute.Click += new System.EventHandler(this.buttonAddAttribute_Click);
            // 
            // listViewShape
            // 
            this.listViewShape.HideSelection = false;
            this.listViewShape.LargeImageList = this.imageListShapes;
            this.listViewShape.Location = new System.Drawing.Point(16, 213);
            this.listViewShape.MultiSelect = false;
            this.listViewShape.Name = "listViewShape";
            this.listViewShape.Size = new System.Drawing.Size(572, 279);
            this.listViewShape.TabIndex = 13;
            this.listViewShape.UseCompatibleStateImageBehavior = false;
            this.listViewShape.View = System.Windows.Forms.View.Tile;
            // 
            // imageListShapes
            // 
            this.imageListShapes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListShapes.ImageStream")));
            this.imageListShapes.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListShapes.Images.SetKeyName(0, "rectangle.png");
            this.imageListShapes.Images.SetKeyName(1, "rounded-rectangle.png");
            this.imageListShapes.Images.SetKeyName(2, "framedrectangle.png");
            this.imageListShapes.Images.SetKeyName(3, "parallelogram.png");
            this.imageListShapes.Images.SetKeyName(4, "trapezoid.png");
            this.imageListShapes.Images.SetKeyName(5, "square.png");
            this.imageListShapes.Images.SetKeyName(6, "ciricle.png");
            this.imageListShapes.Images.SetKeyName(7, "ellipse.png");
            this.imageListShapes.Images.SetKeyName(8, "triangle.png");
            this.imageListShapes.Images.SetKeyName(9, "triangleright.png");
            this.imageListShapes.Images.SetKeyName(10, "triangleleft.png");
            this.imageListShapes.Images.SetKeyName(11, "triangledown.png");
            this.imageListShapes.Images.SetKeyName(12, "diamond.png");
            this.imageListShapes.Images.SetKeyName(13, "pentagon.png");
            this.imageListShapes.Images.SetKeyName(14, "hexagon.png");
            this.imageListShapes.Images.SetKeyName(15, "heptagon.png");
            this.imageListShapes.Images.SetKeyName(16, "octagon.png");
            this.imageListShapes.Images.SetKeyName(17, "procedure.png");
            this.imageListShapes.Images.SetKeyName(18, "cloud.PNG");
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Пиктограмма:";
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Цвет заливки:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Цвет границы:";
            // 
            // buttonFillColorDialog
            // 
            this.buttonFillColorDialog.Location = new System.Drawing.Point(176, 517);
            this.buttonFillColorDialog.Name = "buttonFillColorDialog";
            this.buttonFillColorDialog.Size = new System.Drawing.Size(98, 29);
            this.buttonFillColorDialog.TabIndex = 17;
            this.buttonFillColorDialog.Text = "Настроить...";
            this.buttonFillColorDialog.UseVisualStyleBackColor = true;
            this.buttonFillColorDialog.Click += new System.EventHandler(this.buttonFillColorDialog_Click);
            // 
            // buttonBorderColorDialog
            // 
            this.buttonBorderColorDialog.Location = new System.Drawing.Point(176, 556);
            this.buttonBorderColorDialog.Name = "buttonBorderColorDialog";
            this.buttonBorderColorDialog.Size = new System.Drawing.Size(98, 29);
            this.buttonBorderColorDialog.TabIndex = 18;
            this.buttonBorderColorDialog.Text = "Настроить...";
            this.buttonBorderColorDialog.UseVisualStyleBackColor = true;
            this.buttonBorderColorDialog.Click += new System.EventHandler(this.buttonBorderColorDialog_Click);
            // 
            // panelFillColor
            // 
            this.panelFillColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFillColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFillColor.Location = new System.Drawing.Point(125, 523);
            this.panelFillColor.Name = "panelFillColor";
            this.panelFillColor.Size = new System.Drawing.Size(25, 23);
            this.panelFillColor.TabIndex = 19;
            // 
            // panelStrokeColor
            // 
            this.panelStrokeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelStrokeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStrokeColor.Location = new System.Drawing.Point(125, 562);
            this.panelStrokeColor.Name = "panelStrokeColor";
            this.panelStrokeColor.Size = new System.Drawing.Size(25, 23);
            this.panelStrokeColor.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(658, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Атрибуты:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 615);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Изображение:";
            // 
            // buttonSetImage
            // 
            this.buttonSetImage.Location = new System.Drawing.Point(176, 609);
            this.buttonSetImage.Name = "buttonSetImage";
            this.buttonSetImage.Size = new System.Drawing.Size(98, 29);
            this.buttonSetImage.TabIndex = 23;
            this.buttonSetImage.Text = "Выбрать...";
            this.buttonSetImage.UseVisualStyleBackColor = true;
            this.buttonSetImage.Click += new System.EventHandler(this.buttonSetImage_Click);
            // 
            // labelImgPath
            // 
            this.labelImgPath.AutoSize = true;
            this.labelImgPath.Location = new System.Drawing.Point(296, 615);
            this.labelImgPath.MaximumSize = new System.Drawing.Size(300, 17);
            this.labelImgPath.Name = "labelImgPath";
            this.labelImgPath.Size = new System.Drawing.Size(74, 17);
            this.labelImgPath.TabIndex = 25;
            this.labelImgPath.Text = "imagepath";
            this.labelImgPath.Visible = false;
            // 
            // checkBoxImage
            // 
            this.checkBoxImage.AutoSize = true;
            this.checkBoxImage.Location = new System.Drawing.Point(126, 616);
            this.checkBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxImage.Name = "checkBoxImage";
            this.checkBoxImage.Size = new System.Drawing.Size(18, 17);
            this.checkBoxImage.TabIndex = 26;
            this.checkBoxImage.UseVisualStyleBackColor = true;
            this.checkBoxImage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(658, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Текст вершины:";
            // 
            // textBoxEntityText
            // 
            this.textBoxEntityText.Location = new System.Drawing.Point(872, 15);
            this.textBoxEntityText.Name = "textBoxEntityText";
            this.textBoxEntityText.Size = new System.Drawing.Size(407, 22);
            this.textBoxEntityText.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 68);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Шрифт:";
            // 
            // buttonSetFont
            // 
            this.buttonSetFont.Location = new System.Drawing.Point(872, 62);
            this.buttonSetFont.Name = "buttonSetFont";
            this.buttonSetFont.Size = new System.Drawing.Size(107, 28);
            this.buttonSetFont.TabIndex = 32;
            this.buttonSetFont.Text = "Настроить...";
            this.buttonSetFont.UseVisualStyleBackColor = true;
            this.buttonSetFont.Click += new System.EventHandler(this.buttonSetFont_Click);
            // 
            // labelFontInfo
            // 
            this.labelFontInfo.AutoSize = true;
            this.labelFontInfo.Location = new System.Drawing.Point(998, 68);
            this.labelFontInfo.Name = "labelFontInfo";
            this.labelFontInfo.Size = new System.Drawing.Size(55, 17);
            this.labelFontInfo.TabIndex = 33;
            this.labelFontInfo.Text = "fontinfo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(658, 135);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Родитель:";
            // 
            // lblAncestor
            // 
            this.lblAncestor.AutoSize = true;
            this.lblAncestor.Location = new System.Drawing.Point(739, 135);
            this.lblAncestor.MaximumSize = new System.Drawing.Size(125, 17);
            this.lblAncestor.Name = "lblAncestor";
            this.lblAncestor.Size = new System.Drawing.Size(75, 17);
            this.lblAncestor.TabIndex = 35;
            this.lblAncestor.Text = "Не указан";
            // 
            // btnSetAncestor
            // 
            this.btnSetAncestor.Location = new System.Drawing.Point(872, 129);
            this.btnSetAncestor.Name = "btnSetAncestor";
            this.btnSetAncestor.Size = new System.Drawing.Size(107, 28);
            this.btnSetAncestor.TabIndex = 36;
            this.btnSetAncestor.Text = "Выбрать";
            this.btnSetAncestor.UseVisualStyleBackColor = true;
            // 
            // btnDropAncestor
            // 
            this.btnDropAncestor.Enabled = false;
            this.btnDropAncestor.Location = new System.Drawing.Point(998, 129);
            this.btnDropAncestor.Name = "btnDropAncestor";
            this.btnDropAncestor.Size = new System.Drawing.Size(107, 28);
            this.btnDropAncestor.TabIndex = 37;
            this.btnDropAncestor.Text = "Сбросить";
            this.btnDropAncestor.UseVisualStyleBackColor = true;
            // 
            // EntityEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1291, 651);
            this.Controls.Add(this.btnDropAncestor);
            this.Controls.Add(this.btnSetAncestor);
            this.Controls.Add(this.lblAncestor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelFontInfo);
            this.Controls.Add(this.buttonSetFont);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxEntityText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxImage);
            this.Controls.Add(this.labelImgPath);
            this.Controls.Add(this.buttonSetImage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelStrokeColor);
            this.Controls.Add(this.panelFillColor);
            this.Controls.Add(this.buttonBorderColorDialog);
            this.Controls.Add(this.buttonFillColorDialog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewShape);
            this.Controls.Add(this.buttonAddAttribute);
            this.Controls.Add(this.buttonDeleteAttribute);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxCanSetMaxCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNameInvalidMsg);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.checkBoxIsAbstract);
            this.Controls.Add(this.numericUpDownMaxCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EntityEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор вершины";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAncestor;
        private System.Windows.Forms.Button btnSetAncestor;
        private System.Windows.Forms.Button btnDropAncestor;

        private System.Windows.Forms.Button buttonSetFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label labelFontInfo;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.TextBox textBoxEntityText;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.ToolTip toolTip1;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSetImage;
        private System.Windows.Forms.Label labelImgPath;
        private System.Windows.Forms.CheckBox checkBoxImage;

        private System.Windows.Forms.ImageList imageListShapes;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ListView listViewShape;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCount;
        private System.Windows.Forms.CheckBox checkBoxIsAbstract;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNameInvalidMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCanSetMaxCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDeleteAttribute;
        private System.Windows.Forms.Button buttonAddAttribute;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFillColorDialog;
        private System.Windows.Forms.Button buttonBorderColorDialog;
        private System.Windows.Forms.Panel panelFillColor;
        private System.Windows.Forms.Panel panelStrokeColor;
    }
}