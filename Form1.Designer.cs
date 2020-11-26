namespace Practice_Project_Calculator
{
    partial class Form_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Buttom_Arythm_Op = new System.Windows.Forms.Button();
            this.Button_Trigon_Func = new System.Windows.Forms.Button();
            this.Button_Logarithms = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // Buttom_Arythm_Op
            // 
            this.Buttom_Arythm_Op.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Buttom_Arythm_Op.Location = new System.Drawing.Point(21, 69);
            this.Buttom_Arythm_Op.Name = "Buttom_Arythm_Op";
            this.Buttom_Arythm_Op.Size = new System.Drawing.Size(223, 55);
            this.Buttom_Arythm_Op.TabIndex = 1;
            this.Buttom_Arythm_Op.Text = "Arythmetic operations";
            this.Buttom_Arythm_Op.UseVisualStyleBackColor = true;
            this.Buttom_Arythm_Op.Click += new System.EventHandler(this.Buttom_Arythm_Op_Click);
            // 
            // Button_Trigon_Func
            // 
            this.Button_Trigon_Func.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Trigon_Func.Location = new System.Drawing.Point(21, 130);
            this.Button_Trigon_Func.Name = "Button_Trigon_Func";
            this.Button_Trigon_Func.Size = new System.Drawing.Size(223, 55);
            this.Button_Trigon_Func.TabIndex = 2;
            this.Button_Trigon_Func.Text = "Trigonometric functions";
            this.Button_Trigon_Func.UseVisualStyleBackColor = true;
            this.Button_Trigon_Func.Click += new System.EventHandler(this.Button_Trigon_Func_Click);
            // 
            // Button_Logarithms
            // 
            this.Button_Logarithms.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Logarithms.Location = new System.Drawing.Point(21, 191);
            this.Button_Logarithms.Name = "Button_Logarithms";
            this.Button_Logarithms.Size = new System.Drawing.Size(223, 55);
            this.Button_Logarithms.TabIndex = 3;
            this.Button_Logarithms.Text = "Logarithms";
            this.Button_Logarithms.UseVisualStyleBackColor = true;
            this.Button_Logarithms.Click += new System.EventHandler(this.Button_Logarithms_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Other functions soon...";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Logarithms);
            this.Controls.Add(this.Button_Trigon_Func);
            this.Controls.Add(this.Buttom_Arythm_Op);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buttom_Arythm_Op;
        private System.Windows.Forms.Button Button_Trigon_Func;
        private System.Windows.Forms.Button Button_Logarithms;
        private System.Windows.Forms.Label label2;
    }
}

