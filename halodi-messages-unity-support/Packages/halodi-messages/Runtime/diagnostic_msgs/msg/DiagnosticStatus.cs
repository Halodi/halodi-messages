using System.Text;
namespace diagnostic_msgs.msg
{


/**
       * This message holds the status of an individual component of the robot.
       */
[System.Serializable]
public class DiagnosticStatus : Halodi.CDR.DataType<DiagnosticStatus>
{

	public Halodi.CDR.TopicDataType<DiagnosticStatus> Type => new DiagnosticStatusPubSubType();
	
   /**
          * Possible levels of operations.
          */
   public const byte OK = (byte) 0;
   public const byte WARN = (byte) 1;
   public const byte ERROR = (byte) 2;
   public const byte STALE = (byte) 3;
   /**
            * Level of operation enumerated above.
            */
   public byte level;
   /**
            * A description of the test/component reporting.
            */
   public string name;
   /**
            * A description of the status.
            */
   public string message;
   /**
            * A hardware unique string.
            */
   public string hardware_id;
   /**
            * An array of values associated with the status.
            */
   public System.Collections.Generic.List<diagnostic_msgs.msg.KeyValue> values;


   public void Set(DiagnosticStatus other)
   {
      level = other.level;

      name = other.name;

      message = other.message;

      hardware_id = other.hardware_id;


      if(other.values == null)
      {
      	values = null;
      }
      else
      {
      	values = new System.Collections.Generic.List<diagnostic_msgs.msg.KeyValue>(other.values.Count);
      	for(int i1 = 0; i1 < other.values.Count; i1++)
      	{
      		if(other.values[i1] == null)
      		{
      			values.Add(null);
      		}
      		else
      		{
      			diagnostic_msgs.msg.KeyValue newElement = diagnostic_msgs.msg.KeyValuePubSubType.Create();
      	   		diagnostic_msgs.msg.KeyValuePubSubType.Copy(other.values[i1], newElement);
      	   		values.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("DiagnosticStatus {");
      builder.Append("level=");
      builder.Append(this.level);      builder.Append(", ");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("message=");
      builder.Append(this.message);      builder.Append(", ");
      builder.Append("hardware_id=");
      builder.Append(this.hardware_id);      builder.Append(", ");
      builder.Append("values=");
      builder.Append(this.values);
      builder.Append("}");
      return builder.ToString();
   }
}


}