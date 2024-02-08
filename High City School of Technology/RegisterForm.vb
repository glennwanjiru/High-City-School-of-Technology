' RegisterForm.vb
Imports Firebase.Database

Public Class RegisterForm
    Private firebaseClient As FirebaseClient ' Declare a field to store the FirebaseClient instance

    ' Constructor that takes a FirebaseClient instance as a parameter
    Public Sub New(firebaseClient As FirebaseClient)
        InitializeComponent()
        Me.firebaseClient = firebaseClient
    End Sub

    ' Event handler for the registration button click
    Private Async Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' Determine the gender based on the selected checkboxes
        Dim gender As String
        If MaleCheckBox.Checked Then
            gender = "Male"
        ElseIf FemaleCheckBox.Checked Then
            gender = "Female"
        Else
            ' Handle the case where neither checkbox is selected
            MessageBox.Show("Please select a gender.")
            Exit Sub
        End If

        ' Create a new user based on the entered information
        Dim newUser As New User() With {
            .Name = NameTextBox.Text,
            .Gender = gender,
            .Phone = PhoneTextBox.Text,
            .RegNo = RegNoTextBox.Text,
            .Email = EmailTextBox.Text,
            .DOB = DoB.Value,
            .Country = CountryTextBox.Text
        }

        ' Send the new user data to Firebase Realtime Database using the stored FirebaseClient instance
        Await WriteDataToFirebase(newUser)

        ' Optionally, you can clear the textboxes after registration
        ClearTextBoxes()

        ' Display a success message or perform any additional actions
        MessageBox.Show("Registration successful!")
    End Sub

    ' Method to clear all textboxes
    Private Sub ClearTextBoxes()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            End If
        Next
    End Sub

    ' Method to write user data to Firebase Realtime Database
    Private Async Function WriteDataToFirebase(newUser As User) As Task
        Try
            ' Create a reference to the "users" node
            Dim usersNode As FirebaseObject(Of User) = Await firebaseClient.Child("users").PostAsync(newUser)
        Catch ex As Exception
            ' Handle any exceptions that may occur during Firebase write operation
            MessageBox.Show($"Firebase write error: {ex.Message}")
        End Try
    End Function

    ' ... (other code)
End Class

' User class to represent an individual
Public Class User
    Public Property Name As String
    Public Property Gender As String
    Public Property Phone As String
    Public Property RegNo As String
    Public Property Email As String
    Public Property DOB As DateTime
    Public Property Country As String
End Class
