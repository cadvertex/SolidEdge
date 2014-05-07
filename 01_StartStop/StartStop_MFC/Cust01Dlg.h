// Cust01Dlg.h : header file
#pragma once
#include "afxwin.h"

#import "D:\Program Files\Solid Edge V20\Program\framewrk.tlb" \
rename("GetOpenFileName", "SeGetOpenFileName")

// CCust01Dlg dialog
class CCust01Dlg : public CDialogEx
{
// Construction
public:
	CCust01Dlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_CUST01_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButton1();
	SolidEdgeFramework::ApplicationPtr oApp;
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedButton3();
	afx_msg void OnBnClickedButton4();
	afx_msg void OnBnClickedButton5();
	afx_msg void OnBnClickedCheck1();
	CString statusBarText;
	afx_msg void OnEnChangeEdit1();
	afx_msg void OnBnClickedCheck2();
	CButton chkStatus;
	CButton chkEdgeBar;
	afx_msg void OnBnClickedButton6();
};
