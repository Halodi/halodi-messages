using System.Text;
namespace diagnostic_msgs.msg
{


[System.Serializable]
public class KeyValue : Halodi.CDR.DataType<KeyValue>
{

	public Halodi.CDR.TopicDataType<KeyValue> Type => new KeyValuePubSubType();
	
   /**
            * What to label this value when viewing.
            */
   public string key;
   /**
            * A value to track over time.
            */
   public string value;


   public void Set(KeyValue other)
   {
      key = other.key;

      value = other.value;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("KeyValue {");
      builder.Append("key=");
      builder.Append(this.key);      builder.Append(", ");
      builder.Append("value=");
      builder.Append(this.value);
      builder.Append("}");
      return builder.ToString();
   }
}


}