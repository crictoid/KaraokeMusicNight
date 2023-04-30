' Program Name:		Karaoke Music Night
' Author:			Mark Bulmer 
' Date:				March 28, 2022
' Purpose:			The Karaoke Music Night app determines the karaoke option and calculates the total cost of hours or songs performed. 

Option Strict On

Public Class frmKaraoke

	Private Sub cbolocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOption.SelectedIndexChanged
		' This event handler allows the user to enter the karaoke choice
		Dim intShowingChoice As Integer

		intShowingChoice = cboOption.SelectedIndex

		' Make items visible in the window 

		txtRental.Visible = True
		btnTotalCost.Visible = True
		btnClear.Visible = True
		lblChoose.Visible = True
		lblCost.Visible = True
		' Clear the labels
		lblCost.Text = ""
		' Set focus on number in rental text box
		txtRental.Focus()
	End Sub
	Private Sub btnTotalCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalCost.Click
		' This button event handler determines the number of hours/songs and 
		' displays the cost


		Dim intTotalNumber As Integer
		Dim blnNumberOfRentalIsValid As Boolean = False
		Dim intShowingChoice As Integer
		Dim decTotalCost As Decimal
		Dim decHourlyCost As Decimal = 8.99D
		Dim decSongCost As Decimal = 2.99D

		' Call a function to ensure the number of tickets is valid 
		blnNumberOfRentalIsValid = ValidateNumberOfRental()
		' If number of tickets is valid, calculate the cost 
		If (blnNumberOfRentalIsValid) Then
			intTotalNumber = Convert.ToInt32(txtRental.Text)
			intShowingChoice = cboOption.SelectedIndex
			Select Case intShowingChoice
				Case 0
					decTotalCost = intTotalNumber * decSongCost
					lblSongs.Visible = True
					lblHourly.Visible = False
					lblChoose.Visible = False
				Case 1
					decTotalCost = intTotalNumber * decHourlyCost
					lblHourly.Visible = True
					lblSongs.Visible = False
					lblChoose.Visible = False
			End Select
			' Display the cost of the karaoke night 
			lblCost.Text = "Total Cost of Karaoke Night - " & decTotalCost.ToString("C")
		End If
	End Sub

	Private Function ValidateNumberOfRental() As Boolean
		' This procedure validates the value entered for the number of songs/hours selected
		Dim intTotalNumber As Integer
		Dim blnValidityCheck As Boolean = False
		Dim strNumberOfTicketsMessage As String = "Please enter a valid number (1-12)"
		Dim strMessageBoxTitle As String = "Error"

		Try
			intTotalNumber = Convert.ToInt32(txtRental.Text)
			If intTotalNumber >= 1 And intTotalNumber <= 12 Then
				blnValidityCheck = True
			Else
				MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
				txtRental.Focus()
				txtRental.Clear()
			End If
		Catch Exception As FormatException
			MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
			txtRental.Focus()
			txtRental.Clear()
		Catch Exception As OverflowException
			MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
			txtRental.Focus()
			txtRental.Clear()
		Catch Exception As SystemException
			MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
			txtRental.Focus()
			txtRental.Clear()
		End Try
		Return blnValidityCheck
	End Function

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		' This event handler clears the form and resets the form for reuse when the user clicks the Clear button. 
		cboOption.Text = "Select Location"
		txtRental.Clear()
		lblCost.Text = ""
		lblHourly.Visible = False
		lblSongs.Visible = False
		txtRental.Visible = False
		btnTotalCost.Visible = False
		btnClear.Visible = False
		lblCost.Visible = False
	End Sub

	Private Sub frmIMAX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Hold the splash screen for 3 seconds 
		Threading.Thread.Sleep(3000)
	End Sub

	Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

	End Sub
End Class
