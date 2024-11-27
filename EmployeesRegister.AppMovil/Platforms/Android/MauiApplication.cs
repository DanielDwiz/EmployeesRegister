using Android.Runtime;

namespace EmployeesRegister.AppMovil
{
    public class MauiApplication
    {
        private nint handle;
        private JniHandleOwnership ownership;

        public MauiApplication(nint handle, JniHandleOwnership ownership)
        {
            this.handle = handle;
            this.ownership = ownership;
        }
    }
}