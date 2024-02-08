' FirebaseInitForm.vb
Imports FirebaseAdmin
Imports Google.Apis.Auth.OAuth2
Imports Firebase.Database

Public Class FirebaseInitForm
    Private Sub InitializeFirebase()
        Try
            ' Replace "path/to/your/firebase/credentials.json" with the actual path to your Firebase credentials JSON file
            Dim credentialsPath As String = "C:\Users\glenn\source\repos\High City School of Technology\High City School of Technology\Json\high-city-school-of-technology-firebase-adminsdk-79f17-d36cb504ab.json"

            ' Initialize Firebase using the JSON file
            Dim firebaseCredentials As GoogleCredential = GoogleCredential.FromFile(credentialsPath)
            Dim firebaseApp As FirebaseApp = FirebaseApp.Create(New AppOptions() With {
                .Credential = firebaseCredentials
            })

            ' Replace "your-firebase-database-url" with your actual Firebase Realtime Database URL
            Dim firebaseClient As FirebaseClient = New FirebaseClient("https://console.firebase.google.com/project/high-city-school-of-technology/firestore/data/~2F")

            ' Open the RegisterForm and pass the FirebaseClient instance
            Dim registerForm As New RegisterForm(firebaseClient)
            registerForm.Show()
            Me.Hide()
        Catch ex As Exception
            ' Handle any exceptions that may occur during initialization
            MessageBox.Show($"Firebase initialization error: {ex.Message}")
        End Try
    End Sub

    Private Sub FirebaseInitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFirebase()
    End Sub
End Class
