#pragma once

namespace Cust01 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	using namespace SolidEdgeFramework;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
		}

		SolidEdgeFramework::Application^ oApp;
        Type^ typ;

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	internal: System::Windows::Forms::CheckBox^  chkEdge;
	protected: 
	internal: System::Windows::Forms::CheckBox^  chkStatus;
	private: System::Windows::Forms::TextBox^  txtStatus;
	internal: 
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Button^  cmdQuit;
	private: System::Windows::Forms::Button^  cmdAppend;
	private: System::Windows::Forms::Button^  cmdVersion;
	private: System::Windows::Forms::Button^  cmdHide;
	private: System::Windows::Forms::Button^  cmdShow;
	private: System::Windows::Forms::Button^  cmdStart;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->chkEdge = (gcnew System::Windows::Forms::CheckBox());
			this->chkStatus = (gcnew System::Windows::Forms::CheckBox());
			this->txtStatus = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->cmdQuit = (gcnew System::Windows::Forms::Button());
			this->cmdAppend = (gcnew System::Windows::Forms::Button());
			this->cmdVersion = (gcnew System::Windows::Forms::Button());
			this->cmdHide = (gcnew System::Windows::Forms::Button());
			this->cmdShow = (gcnew System::Windows::Forms::Button());
			this->cmdStart = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// chkEdge
			// 
			this->chkEdge->AutoSize = true;
			this->chkEdge->Location = System::Drawing::Point(24, 317);
			this->chkEdge->Name = L"chkEdge";
			this->chkEdge->Size = System::Drawing::Size(107, 17);
			this->chkEdge->TabIndex = 52;
			this->chkEdge->Text = L"Display Edge Bar";
			this->chkEdge->UseVisualStyleBackColor = true;
			this->chkEdge->CheckedChanged += gcnew System::EventHandler(this, &Form1::chkEdge_CheckedChanged);
			// 
			// chkStatus
			// 
			this->chkStatus->AutoSize = true;
			this->chkStatus->Location = System::Drawing::Point(24, 294);
			this->chkStatus->Name = L"chkStatus";
			this->chkStatus->Size = System::Drawing::Size(112, 17);
			this->chkStatus->TabIndex = 51;
			this->chkStatus->Text = L"Display Status Bar";
			this->chkStatus->UseVisualStyleBackColor = true;
			this->chkStatus->CheckedChanged += gcnew System::EventHandler(this, &Form1::chkStatus_CheckedChanged);
			// 
			// txtStatus
			// 
			this->txtStatus->Font = (gcnew System::Drawing::Font(L"Verdana", 9, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->txtStatus->Location = System::Drawing::Point(24, 215);
			this->txtStatus->Name = L"txtStatus";
			this->txtStatus->Size = System::Drawing::Size(138, 22);
			this->txtStatus->TabIndex = 50;
			this->txtStatus->Text = L" www.cadvertex.com";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->label1->FlatStyle = System::Windows::Forms::FlatStyle::Popup;
			this->label1->Location = System::Drawing::Point(24, 186);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(2, 15);
			this->label1->TabIndex = 49;
			// 
			// cmdQuit
			// 
			this->cmdQuit->Location = System::Drawing::Point(24, 353);
			this->cmdQuit->Name = L"cmdQuit";
			this->cmdQuit->Size = System::Drawing::Size(138, 38);
			this->cmdQuit->TabIndex = 48;
			this->cmdQuit->Text = L"Quit Solid Edge";
			this->cmdQuit->UseVisualStyleBackColor = true;
			this->cmdQuit->Click += gcnew System::EventHandler(this, &Form1::cmdQuit_Click);
			// 
			// cmdAppend
			// 
			this->cmdAppend->Location = System::Drawing::Point(24, 241);
			this->cmdAppend->Name = L"cmdAppend";
			this->cmdAppend->Size = System::Drawing::Size(138, 38);
			this->cmdAppend->TabIndex = 45;
			this->cmdAppend->Text = L"Append to Status bar";
			this->cmdAppend->UseVisualStyleBackColor = true;
			this->cmdAppend->Click += gcnew System::EventHandler(this, &Form1::cmdAppend_Click);
			// 
			// cmdVersion
			// 
			this->cmdVersion->Location = System::Drawing::Point(24, 135);
			this->cmdVersion->Name = L"cmdVersion";
			this->cmdVersion->Size = System::Drawing::Size(138, 38);
			this->cmdVersion->TabIndex = 44;
			this->cmdVersion->Text = L"Display Version";
			this->cmdVersion->UseVisualStyleBackColor = true;
			this->cmdVersion->Click += gcnew System::EventHandler(this, &Form1::cmdVersion_Click);
			// 
			// cmdHide
			// 
			this->cmdHide->Location = System::Drawing::Point(99, 82);
			this->cmdHide->Name = L"cmdHide";
			this->cmdHide->Size = System::Drawing::Size(63, 38);
			this->cmdHide->TabIndex = 47;
			this->cmdHide->Text = L"Hide";
			this->cmdHide->UseVisualStyleBackColor = true;
			this->cmdHide->Click += gcnew System::EventHandler(this, &Form1::cmdHide_Click);
			// 
			// cmdShow
			// 
			this->cmdShow->Location = System::Drawing::Point(24, 82);
			this->cmdShow->Name = L"cmdShow";
			this->cmdShow->Size = System::Drawing::Size(69, 38);
			this->cmdShow->TabIndex = 46;
			this->cmdShow->Text = L"Show";
			this->cmdShow->UseVisualStyleBackColor = true;
			this->cmdShow->Click += gcnew System::EventHandler(this, &Form1::cmdShow_Click);
			// 
			// cmdStart
			// 
			this->cmdStart->Location = System::Drawing::Point(24, 12);
			this->cmdStart->Name = L"cmdStart";
			this->cmdStart->Size = System::Drawing::Size(138, 50);
			this->cmdStart->TabIndex = 43;
			this->cmdStart->Text = L"Start Solid Edge";
			this->cmdStart->UseVisualStyleBackColor = true;
			this->cmdStart->Click += gcnew System::EventHandler(this, &Form1::cmdStart_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(186, 399);
			this->Controls->Add(this->chkEdge);
			this->Controls->Add(this->chkStatus);
			this->Controls->Add(this->txtStatus);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->cmdQuit);
			this->Controls->Add(this->cmdAppend);
			this->Controls->Add(this->cmdVersion);
			this->Controls->Add(this->cmdHide);
			this->Controls->Add(this->cmdShow);
			this->Controls->Add(this->cmdStart);
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"Form1";
			this->Text = L"Solid Edge: C++/CLI";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void cmdStart_Click(System::Object^  sender, System::EventArgs^  e) {
		typ = Type::GetTypeFromProgID("SolidEdge.Application");
		oApp =  (SolidEdgeFramework::Application^)Activator::CreateInstance(typ);
		}

private: System::Void cmdShow_Click(System::Object^  sender, System::EventArgs^  e) {
			 oApp->Visible = true;
		 }

private: System::Void cmdHide_Click(System::Object^  sender, System::EventArgs^  e) {
			 oApp->Visible = false;
		 }

private: System::Void cmdVersion_Click(System::Object^  sender, System::EventArgs^  e) {
			 label1->Text = oApp->Name + " - " + oApp->Version;
		 }

private: System::Void cmdAppend_Click(System::Object^  sender, System::EventArgs^  e) {
			 oApp->StatusBar += txtStatus->Text;
		 }

private: System::Void chkStatus_CheckedChanged(System::Object^  sender, System::EventArgs^  e) {
            oApp->StatusBarVisible = chkStatus->Checked;
		 }

private: System::Void chkEdge_CheckedChanged(System::Object^  sender, System::EventArgs^  e) {
            oApp->EdgeBarVisible = chkEdge->Checked;
		 }

private: System::Void cmdQuit_Click(System::Object^  sender, System::EventArgs^  e) {
			 oApp->Quit();
		 }
};
}
