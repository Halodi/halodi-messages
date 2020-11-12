using System.Text;
namespace rcl_interfaces.msg
{


[System.Serializable]
public class SetParametersResult
{
   /**
            * A true value of the same index indicates that the parameter was set successfully.
            * A false value indicates the change was rejected.
            */
   public bool successful;
   /**
            * Reason why the setting was either successful or a failure.
            * Should only be used for logging and user interfaces.
            */
   public string reason;


   public void Set(SetParametersResult other)
   {
      successful = other.successful;

      reason = other.reason;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("SetParametersResult {");
      builder.Append("successful=");
      builder.Append(this.successful);      builder.Append(", ");
      builder.Append("reason=");
      builder.Append(this.reason);
      builder.Append("}");
      return builder.ToString();
   }
}


}