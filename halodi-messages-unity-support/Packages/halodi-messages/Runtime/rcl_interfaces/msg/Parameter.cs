using System.Text;
namespace rcl_interfaces.msg
{


/**
       * This is the message to communicate a parameter.
       * It is an open struct with an enum in the descriptor to select which value is active.
       */
[System.Serializable]
public class Parameter : Halodi.CDR.DataType<Parameter>
{

	public Halodi.CDR.TopicDataType<Parameter> Type => new ParameterPubSubType();
	
   public string name;
   public rcl_interfaces.msg.ParameterValue value;


   public void Set(Parameter other)
   {
      name = other.name;

      rcl_interfaces.msg.ParameterValuePubSubType.Copy(other.value, value);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Parameter {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("value=");
      builder.Append(this.value);
      builder.Append("}");
      return builder.ToString();
   }
}


}