namespace SimpleClinicWinForm.Payments.Controls
{
    partial class ctrlPaymentCardWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.ctrlPaymentCard1 = new SimpleClinicWinForm.Payments.Controls.ctrlPaymentCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAdd);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.txtPaymentID);
            this.gbFilter.Location = new System.Drawing.Point(18, 23);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(599, 100);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(503, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(397, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 53);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PaymentID:";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(119, 42);
            this.txtPaymentID.Multiline = true;
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(260, 31);
            this.txtPaymentID.TabIndex = 0;
            this.txtPaymentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentID_KeyPress);
            // 
            // ctrlPaymentCard1
            // 
            this.ctrlPaymentCard1.Location = new System.Drawing.Point(18, 129);
            this.ctrlPaymentCard1.Name = "ctrlPaymentCard1";
            this.ctrlPaymentCard1.Size = new System.Drawing.Size(540, 404);
            this.ctrlPaymentCard1.TabIndex = 3;
            // 
            // ctrlPaymentCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPaymentCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlPaymentCardWithFilter";
            this.Size = new System.Drawing.Size(631, 530);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaymentID;
        private ctrlPaymentCard ctrlPaymentCard1;
    }
}
