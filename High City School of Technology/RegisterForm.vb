' RegisterForm.vb
Imports Firebase.Database

Public Class RegisterForm
    ' Declare a private variable to store the FirebaseClient instance
    Private firebaseClient As FirebaseClient

    ' Constructor that accepts a FirebaseClient parameter
    Public Sub New(firebaseClient As FirebaseClient)
        ' Initialize the FirebaseClient instance
        Me.firebaseClient = firebaseClient

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Your other initialization code, if any...
    End Sub

    ' ... (other code)

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

        ' Send the new user data to Firebase Realtime Database
        Await WriteDataToFirebase(newUser)

        ' Optionally, you can clear the textboxes after registration
        ClearTextBoxes()

        ' Display a success message or perform any additional actions
        MessageBox.Show("Registration successful!")
    End Sub

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
