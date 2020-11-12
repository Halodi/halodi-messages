using System.Text;
namespace rcl_interfaces.msg
{


[System.Serializable]
public class ParameterType
{
   public const byte PARAMETER_NOT_SET = (byte) 0;
   public const byte PARAMETER_BOOL = (byte) 1;
   public const byte PARAMETER_INTEGER = (byte) 2;
   public const byte PARAMETER_DOUBLE = (byte) 3;
   public const byte PARAMETER_STRING = (byte) 4;
   public const byte PARAMETER_BYTE_ARRAY = (byte) 5;
   public const byte PARAMETER_BOOL_ARRAY = (byte) 6;
   public const byte PARAMETER_INTEGER_ARRAY = (byte) 7;
   public const byte PARAMETER_DOUBLE_ARRAY = (byte) 8;
   public const byte PARAMETER_STRING_ARRAY = (byte) 9;
   public bool unused_placeholder_field;


   public void Set(ParameterType other)
   {
      unused_placeholder_field = other.unused_placeholder_field;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ParameterType {");
      builder.Append("unused_placeholder_field=");
      builder.Append(this.unused_placeholder_field);
      builder.Append("}");
      return builder.ToString();
   }
}


}