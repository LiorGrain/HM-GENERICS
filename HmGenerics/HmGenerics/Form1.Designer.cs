
namespace HmGenerics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FindById = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.typebox2 = new System.Windows.Forms.TextBox();
            this.typebox1 = new System.Windows.Forms.TextBox();
            this.varibaletypebotton = new System.Windows.Forms.Button();
            this.findteacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addnewteacher = new System.Windows.Forms.Button();
            this.textboxup = new System.Windows.Forms.TextBox();
            this.textboxdow = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.typeBoxx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GiveType = new System.Windows.Forms.Button();
            this.textBoxlast1 = new System.Windows.Forms.TextBox();
            this.textBoxlast2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindById
            // 
            this.FindById.Location = new System.Drawing.Point(37, 40);
            this.FindById.Name = "FindById";
            this.FindById.Size = new System.Drawing.Size(122, 38);
            this.FindById.TabIndex = 0;
            this.FindById.Text = "FindBy ID";
            this.FindById.UseVisualStyleBackColor = true;
            this.FindById.Click += new System.EventHandler(this.FindById_Click);
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(165, 68);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(125, 27);
            this.StudentName.TabIndex = 1;
            this.StudentName.TextChanged += new System.EventHandler(this.StudentName_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "ReadOnly";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "addNewStudent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(258, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 20);
            this.name.TabIndex = 5;
            this.name.Text = "name";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(271, 96);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(22, 20);
            this.id.TabIndex = 6;
            this.id.Text = "id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentName);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.FindById);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 232);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.typebox2);
            this.groupBox2.Controls.Add(this.typebox1);
            this.groupBox2.Controls.Add(this.varibaletypebotton);
            this.groupBox2.Location = new System.Drawing.Point(345, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 232);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // typebox2
            // 
            this.typebox2.Location = new System.Drawing.Point(150, 92);
            this.typebox2.Name = "typebox2";
            this.typebox2.Size = new System.Drawing.Size(125, 27);
            this.typebox2.TabIndex = 2;
            // 
            // typebox1
            // 
            this.typebox1.Location = new System.Drawing.Point(150, 48);
            this.typebox1.Name = "typebox1";
            this.typebox1.Size = new System.Drawing.Size(125, 27);
            this.typebox1.TabIndex = 1;
            this.typebox1.TextChanged += new System.EventHandler(this.typebox1_TextChanged);
            // 
            // varibaletypebotton
            // 
            this.varibaletypebotton.Location = new System.Drawing.Point(6, 46);
            this.varibaletypebotton.Name = "varibaletypebotton";
            this.varibaletypebotton.Size = new System.Drawing.Size(122, 29);
            this.varibaletypebotton.TabIndex = 0;
            this.varibaletypebotton.Text = "varibale type";
            this.varibaletypebotton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.varibaletypebotton.UseVisualStyleBackColor = true;
            this.varibaletypebotton.Click += new System.EventHandler(this.varibaletypebotton_Click);
            // 
            // findteacher
            // 
            this.findteacher.Location = new System.Drawing.Point(12, 320);
            this.findteacher.Name = "findteacher";
            this.findteacher.Size = new System.Drawing.Size(174, 38);
            this.findteacher.TabIndex = 9;
            this.findteacher.Text = "FindteacherID";
            this.findteacher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.findteacher.UseVisualStyleBackColor = true;
            this.findteacher.Click += new System.EventHandler(this.findteacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "class/teacher";
            // 
            // addnewteacher
            // 
            this.addnewteacher.Location = new System.Drawing.Point(12, 271);
            this.addnewteacher.Name = "addnewteacher";
            this.addnewteacher.Size = new System.Drawing.Size(174, 43);
            this.addnewteacher.TabIndex = 13;
            this.addnewteacher.Text = "addNewteacher/class";
            this.addnewteacher.UseVisualStyleBackColor = true;
            this.addnewteacher.Click += new System.EventHandler(this.addnewteacher_Click);
            // 
            // textboxup
            // 
            this.textboxup.Location = new System.Drawing.Point(214, 287);
            this.textboxup.Name = "textboxup";
            this.textboxup.Size = new System.Drawing.Size(125, 27);
            this.textboxup.TabIndex = 15;
            // 
            // textboxdow
            // 
            this.textboxdow.Location = new System.Drawing.Point(214, 320);
            this.textboxdow.Name = "textboxdow";
            this.textboxdow.Size = new System.Drawing.Size(125, 27);
            this.textboxdow.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "findClass";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // typeBoxx
            // 
            this.typeBoxx.Location = new System.Drawing.Point(214, 353);
            this.typeBoxx.Name = "typeBoxx";
            this.typeBoxx.Size = new System.Drawing.Size(125, 27);
            this.typeBoxx.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "type";
            // 
            // GiveType
            // 
            this.GiveType.Location = new System.Drawing.Point(495, 287);
            this.GiveType.Name = "GiveType";
            this.GiveType.Size = new System.Drawing.Size(138, 41);
            this.GiveType.TabIndex = 21;
            this.GiveType.Text = "GiveType";
            this.GiveType.UseVisualStyleBackColor = true;
            this.GiveType.Click += new System.EventHandler(this.GiveType_Click);
            // 
            // textBoxlast1
            // 
            this.textBoxlast1.Location = new System.Drawing.Point(639, 290);
            this.textBoxlast1.Name = "textBoxlast1";
            this.textBoxlast1.Size = new System.Drawing.Size(125, 27);
            this.textBoxlast1.TabIndex = 22;
            // 
            // textBoxlast2
            // 
            this.textBoxlast2.Location = new System.Drawing.Point(639, 331);
            this.textBoxlast2.Name = "textBoxlast2";
            this.textBoxlast2.Size = new System.Drawing.Size(125, 27);
            this.textBoxlast2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxlast2);
            this.Controls.Add(this.textBoxlast1);
            this.Controls.Add(this.GiveType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBoxx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textboxdow);
            this.Controls.Add(this.textboxup);
            this.Controls.Add(this.findteacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnewteacher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindById;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox typebox1;
        private System.Windows.Forms.Button varibaletypebotton;
        private System.Windows.Forms.TextBox typebox2;
        private System.Windows.Forms.Button findteacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnewteacher;
        private System.Windows.Forms.TextBox textboxup;
        private System.Windows.Forms.TextBox textboxdow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox typeBoxx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GiveType;
        private System.Windows.Forms.TextBox textBoxlast1;
        private System.Windows.Forms.TextBox textBoxlast2;
    }
}

