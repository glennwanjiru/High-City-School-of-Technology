' FirebaseInitForm.vb
Imports FirebaseAdmin
Imports Google.Apis.Auth.OAuth2
Imports Firebase.Database

Public Class FirebaseInitForm
    Private Sub InitializeFirebase()
        Dim credentialsPath As String = "C:\Users\glenn\source\repos\High City School of Technology\High City School of Technology\Json\high-city-school-of-technology-firebase-adminsdk-79f17-d36cb504ab.json"

        ' Initialize Firebase using the JSON file
        Dim firebaseCredentials As GoogleCredential = GoogleCredential.FromFile(credentialsPath)
        Dim firebaseApp As FirebaseApp = FirebaseApp.Create(New AppOptions() With {
            .Credential = firebaseCredentials
        })

        ' Open the RegisterForm instead of MainForm
        Dim registerForm As New RegisterForm(New FirebaseClient("https://console.firebase.google.com/project/high-city-school-of-technology/firestore/data/~2F"))
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub FirebaseInitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFirebase()
    End Sub
End Class
