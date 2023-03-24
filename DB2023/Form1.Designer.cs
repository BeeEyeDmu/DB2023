namespace DB2023
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.listView1 = new System.Windows.Forms.ListView();
      this.label2 = new System.Windows.Forms.Label();
      this.txtId = new System.Windows.Forms.TextBox();
      this.txtSId = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnViewAll = new System.Windows.Forms.Button();
      this.btnInsert = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.HideSelection = false;
      this.listView1.Location = new System.Drawing.Point(13, 13);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(459, 210);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(23, 251);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(19, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "ID";
      // 
      // txtId
      // 
      this.txtId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtId.Location = new System.Drawing.Point(94, 248);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(140, 23);
      this.txtId.TabIndex = 3;
      // 
      // txtSId
      // 
      this.txtSId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSId.Location = new System.Drawing.Point(94, 275);
      this.txtSId.Name = "txtSId";
      this.txtSId.Size = new System.Drawing.Size(140, 23);
      this.txtSId.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
      this.label3.Location = new System.Drawing.Point(23, 278);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 15);
      this.label3.TabIndex = 4;
      this.label3.Text = "학번";
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtName.Location = new System.Drawing.Point(94, 302);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(140, 23);
      this.txtName.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label4.Location = new System.Drawing.Point(23, 305);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "이름";
      // 
      // txtPhone
      // 
      this.txtPhone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtPhone.Location = new System.Drawing.Point(94, 329);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(140, 23);
      this.txtPhone.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label5.Location = new System.Drawing.Point(23, 332);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 15);
      this.label5.TabIndex = 8;
      this.label5.Text = "전화번호";
      // 
      // btnViewAll
      // 
      this.btnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnViewAll.Location = new System.Drawing.Point(270, 246);
      this.btnViewAll.Name = "btnViewAll";
      this.btnViewAll.Size = new System.Drawing.Size(75, 23);
      this.btnViewAll.TabIndex = 10;
      this.btnViewAll.Text = "View All";
      this.btnViewAll.UseVisualStyleBackColor = true;
      // 
      // btnInsert
      // 
      this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnInsert.Location = new System.Drawing.Point(270, 273);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(75, 23);
      this.btnInsert.TabIndex = 11;
      this.btnInsert.Text = "추가";
      this.btnInsert.UseVisualStyleBackColor = true;
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnSearch.Location = new System.Drawing.Point(270, 300);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 12;
      this.btnSearch.Text = "검색";
      this.btnSearch.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnClear.Location = new System.Drawing.Point(270, 327);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 13;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnDelete.Location = new System.Drawing.Point(370, 273);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 14;
      this.btnDelete.Text = "삭제";
      this.btnDelete.UseVisualStyleBackColor = true;
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnUpdate.Location = new System.Drawing.Point(370, 300);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 23);
      this.btnUpdate.TabIndex = 15;
      this.btnUpdate.Text = "수정";
      this.btnUpdate.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnClose.Location = new System.Drawing.Point(370, 327);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 16;
      this.btnClose.Text = "종료";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 370);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.btnInsert);
      this.Controls.Add(this.btnViewAll);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtSId);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listView1);
      this.Name = "Form1";
      this.Text = "전화번호부";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtSId;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnViewAll;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClose;
  }
}

