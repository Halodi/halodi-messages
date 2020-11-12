using System.Text;
namespace tf2_msgs.msg
{


[System.Serializable]
public class TF2Error
{
   public const byte NO_ERROR = (byte) 0;
   public const byte LOOKUP_ERROR = (byte) 1;
   public const byte CONNECTIVITY_ERROR = (byte) 2;
   public const byte EXTRAPOLATION_ERROR = (byte) 3;
   public const byte INVALID_ARGUMENT_ERROR = (byte) 4;
   public const byte TIMEOUT_ERROR = (byte) 5;
   public const byte TRANSFORM_ERROR = (byte) 6;
   public byte error;
   public string error_string;


   public void Set(TF2Error other)
   {
      error = other.error;

      error_string = other.error_string;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TF2Error {");
      builder.Append("error=");
      builder.Append(this.error);      builder.Append(", ");
      builder.Append("error_string=");
      builder.Append(this.error_string);
      builder.Append("}");
      return builder.ToString();
   }
}


}