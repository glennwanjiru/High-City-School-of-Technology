' Application.Designer.vb
Imports Firebase.Database

Namespace My
    Partial Friend Class MyApplication
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutdownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

        Protected Overrides Sub OnCreateMainForm()
            ' Create a new FirebaseClient instance with your Firebase Realtime Database URL
            Dim firebaseClient As New FirebaseClient("https://high-city-school-of-technology-default-rtdb.firebaseio.com/")

            ' Pass the FirebaseClient instance to the RegisterForm constructor
            Me.MainForm = New Global.High_City_School_of_Technology.RegisterForm(firebaseClient)
        End Sub
    End Class
End Namespace
