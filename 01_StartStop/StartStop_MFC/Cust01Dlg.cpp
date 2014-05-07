// Cust01Dlg.cpp : implementation file

#include "stdafx.h"
#include "Cust01.h"
#include "Cust01Dlg.h"
#include "afxdialogex.h"

#include <iostream>
using namespace std;

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// CCust01Dlg dialog

CCust01Dlg::CCust01Dlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CCust01Dlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CCust01Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_CHECK1, chkStatus);
	DDX_Control(pDX, IDC_CHECK2, chkEdgeBar);
}

BEGIN_MESSAGE_MAP(CCust01Dlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, &CCust01Dlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CCust01Dlg::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CCust01Dlg::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &CCust01Dlg::OnBnClickedButton4)
	ON_BN_CLICKED(IDC_BUTTON5, &CCust01Dlg::OnBnClickedButton5)
	ON_BN_CLICKED(IDC_CHECK1, &CCust01Dlg::OnBnClickedCheck1)
	ON_EN_CHANGE(IDC_EDIT1, &CCust01Dlg::OnEnChangeEdit1)
	ON_BN_CLICKED(IDC_CHECK2, &CCust01Dlg::OnBnClickedCheck2)
	ON_BN_CLICKED(IDC_BUTTON6, &CCust01Dlg::OnBnClickedButton6)
END_MESSAGE_MAP()


// CCust01Dlg message handlers

BOOL CCust01Dlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CCust01Dlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CCust01Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CCust01Dlg::OnBnClickedButton1()
{
	try
	{
		CoInitialize(NULL);

		this->oApp.CreateInstance("SolidEdge.Application");
		SetDlgItemText(IDC_STATIC, "Solid Edge has started.");

		//oApp.GetActiveObject("SolidEdge.Application");
		//SetDlgItemText(IDC_STATIC, "Connected !");
	}
	catch(_com_error &error)
	{
		MessageBox("COM Error", "Error", 0);
		CoUninitialize();
	}
}

void CCust01Dlg::OnBnClickedButton2()
{
	this->oApp->Visible = true;
}

void CCust01Dlg::OnBnClickedButton3()
{
	this->oApp->Visible = false;
}

void CCust01Dlg::OnBnClickedButton4()
{
	_bstr_t seVersion(this->oApp->Version);
	string SEversion((char*)seVersion);
	MessageBox(SEversion.c_str(), "Version", 0);
}

void CCust01Dlg::OnBnClickedButton5()
{
	_bstr_t StatusBarText(statusBarText);
	oApp->StatusBar += StatusBarText;
}

void CCust01Dlg::OnBnClickedCheck1()
{
	if (chkStatus.GetCheck() == 1)
		this->oApp->StatusBarVisible = TRUE;
	if (chkStatus.GetCheck() == 0)
		this->oApp->StatusBarVisible = FALSE;
}

void CCust01Dlg::OnEnChangeEdit1()
{
	GetDlgItemText(IDC_EDIT1, statusBarText);
}

void CCust01Dlg::OnBnClickedCheck2()
{
	if (chkEdgeBar.GetCheck() == 1)
		this->oApp->EdgeBarVisible = TRUE;
	if (chkEdgeBar.GetCheck() == 0)
		this->oApp->EdgeBarVisible = FALSE;
}

void CCust01Dlg::OnBnClickedButton6()
{
	this->oApp->Quit();
}
