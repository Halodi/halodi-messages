using System.Text;
namespace rcl_interfaces.msg
{


/**
       * Used to determine which of the next *_value fields are set.
       * ParameterType.PARAMETER_NOT_SET indicates that the parameter was not set
       * (if gotten) or is uninitialized.
       * Values are enumerated in ParameterType.msg
       */
[System.Serializable]
public class ParameterValue : Halodi.CDR.DataType<ParameterValue>
{

	public Halodi.CDR.TopicDataType<ParameterValue> Type => new ParameterValuePubSubType();
	
   public byte type;
   /**
            * "Variant" style storage of the parameter value.
            */
   public bool bool_value;
   public long integer_value;
   public double double_value;
   public string string_value;
   public System.Collections.Generic.List<byte> byte_array_value;
   public System.Collections.Generic.List<bool> bool_array_value;
   public System.Collections.Generic.List<long> integer_array_value;
   public System.Collections.Generic.List<double> double_array_value;
   public System.Collections.Generic.List<string> string_array_value;


   public void Set(ParameterValue other)
   {
      type = other.type;

      bool_value = other.bool_value;

      integer_value = other.integer_value;

      double_value = other.double_value;

      string_value = other.string_value;


      if(other.byte_array_value == null)
      {
      	byte_array_value = null;
      }
      else
      {
      	byte_array_value = new System.Collections.Generic.List<byte>(other.byte_array_value.Count);
      	for(int i1 = 0; i1 < other.byte_array_value.Count; i1++)
      	{
         		byte_array_value.Add(other.byte_array_value[i1]);
      	}
      }

      if(other.bool_array_value == null)
      {
      	bool_array_value = null;
      }
      else
      {
      	bool_array_value = new System.Collections.Generic.List<bool>(other.bool_array_value.Count);
      	for(int i2 = 0; i2 < other.bool_array_value.Count; i2++)
      	{
         		bool_array_value.Add(other.bool_array_value[i2]);
      	}
      }

      if(other.integer_array_value == null)
      {
      	integer_array_value = null;
      }
      else
      {
      	integer_array_value = new System.Collections.Generic.List<long>(other.integer_array_value.Count);
      	for(int i3 = 0; i3 < other.integer_array_value.Count; i3++)
      	{
         		integer_array_value.Add(other.integer_array_value[i3]);
      	}
      }

      if(other.double_array_value == null)
      {
      	double_array_value = null;
      }
      else
      {
      	double_array_value = new System.Collections.Generic.List<double>(other.double_array_value.Count);
      	for(int i4 = 0; i4 < other.double_array_value.Count; i4++)
      	{
         		double_array_value.Add(other.double_array_value[i4]);
      	}
      }

      if(other.string_array_value == null)
      {
      	string_array_value = null;
      }
      else
      {
      	string_array_value = new System.Collections.Generic.List<string>(other.string_array_value.Count);
      	for(int i5 = 0; i5 < other.string_array_value.Count; i5++)
      	{
         		string_array_value.Add(other.string_array_value[i5]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ParameterValue {");
      builder.Append("type=");
      builder.Append(this.type);      builder.Append(", ");
      builder.Append("bool_value=");
      builder.Append(this.bool_value);      builder.Append(", ");
      builder.Append("integer_value=");
      builder.Append(this.integer_value);      builder.Append(", ");
      builder.Append("double_value=");
      builder.Append(this.double_value);      builder.Append(", ");
      builder.Append("string_value=");
      builder.Append(this.string_value);      builder.Append(", ");
      builder.Append("byte_array_value=");
      builder.Append(this.byte_array_value);      builder.Append(", ");
      builder.Append("bool_array_value=");
      builder.Append(this.bool_array_value);      builder.Append(", ");
      builder.Append("integer_array_value=");
      builder.Append(this.integer_array_value);      builder.Append(", ");
      builder.Append("double_array_value=");
      builder.Append(this.double_array_value);      builder.Append(", ");
      builder.Append("string_array_value=");
      builder.Append(this.string_array_value);
      builder.Append("}");
      return builder.ToString();
   }
}


}