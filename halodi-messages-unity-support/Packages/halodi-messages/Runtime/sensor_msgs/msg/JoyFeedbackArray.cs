using System.Text;
namespace sensor_msgs.msg
{


[System.Serializable]
public class JoyFeedbackArray : Halodi.CDR.DataType<JoyFeedbackArray>
{

	public Halodi.CDR.TopicDataType<JoyFeedbackArray> Type => new JoyFeedbackArrayPubSubType();
	
   /**
            * This message publishes values for multiple feedback at once.
            */
   public System.Collections.Generic.List<sensor_msgs.msg.JoyFeedback> array;


   public void Set(JoyFeedbackArray other)
   {

      if(other.array == null)
      {
      	array = null;
      }
      else
      {
      	array = new System.Collections.Generic.List<sensor_msgs.msg.JoyFeedback>(other.array.Count);
      	for(int i1 = 0; i1 < other.array.Count; i1++)
      	{
      		if(other.array[i1] == null)
      		{
      			array.Add(null);
      		}
      		else
      		{
      			sensor_msgs.msg.JoyFeedback newElement = sensor_msgs.msg.JoyFeedbackPubSubType.Create();
      	   		sensor_msgs.msg.JoyFeedbackPubSubType.Copy(other.array[i1], newElement);
      	   		array.Add(newElement);
      		}	}
      }   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JoyFeedbackArray {");
      builder.Append("array=");
      builder.Append(this.array);
      builder.Append("}");
      return builder.ToString();
   }
}


}