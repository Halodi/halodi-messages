using System.Text;
namespace diagnostic_msgs.msg
{


[System.Serializable]
public class DiagnosticArray
{
   /**
            * This message is used to send diagnostic information about the state of the robot.
            * for timestamp
            */
   public std_msgs.msg.Header header;
   /**
            * an array of components being reported on
            */
   public System.Collections.Generic.List<diagnostic_msgs.msg.DiagnosticStatus> status;


   public void Set(DiagnosticArray other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.status == null)
      {
      	status = null;
      }
      else
      {
      	status = new System.Collections.Generic.List<diagnostic_msgs.msg.DiagnosticStatus>(other.status.Count);
      	for(int i1 = 0; i1 < other.status.Count; i1++)
      	{
      		if(other.status[i1] == null)
      		{
      			status.Add(null);
      		}
      		else
      		{
      			diagnostic_msgs.msg.DiagnosticStatus newElement = diagnostic_msgs.msg.DiagnosticStatusPubSubType.Create();
      	   		diagnostic_msgs.msg.DiagnosticStatusPubSubType.Copy(other.status[i1], newElement);
      	   		status.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("DiagnosticArray {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("status=");
      builder.Append(this.status);
      builder.Append("}");
      return builder.ToString();
   }
}


}