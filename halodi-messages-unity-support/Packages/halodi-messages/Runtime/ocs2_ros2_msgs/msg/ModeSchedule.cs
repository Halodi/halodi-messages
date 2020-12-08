using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class ModeSchedule : Halodi.CDR.DataType<ModeSchedule>
{

	public Halodi.CDR.TopicDataType<ModeSchedule> Type => new ModeSchedulePubSubType();
	
   public System.Collections.Generic.List<float> event_times;
   public System.Collections.Generic.List<int> mode_sequence;


   public void Set(ModeSchedule other)
   {

      if(other.event_times == null)
      {
      	event_times = null;
      }
      else
      {
      	event_times = new System.Collections.Generic.List<float>(other.event_times.Count);
      	for(int i1 = 0; i1 < other.event_times.Count; i1++)
      	{
         		event_times.Add(other.event_times[i1]);
      	}
      }

      if(other.mode_sequence == null)
      {
      	mode_sequence = null;
      }
      else
      {
      	mode_sequence = new System.Collections.Generic.List<int>(other.mode_sequence.Count);
      	for(int i2 = 0; i2 < other.mode_sequence.Count; i2++)
      	{
         		mode_sequence.Add(other.mode_sequence[i2]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ModeSchedule {");
      builder.Append("event_times=");
      builder.Append(this.event_times);      builder.Append(", ");
      builder.Append("mode_sequence=");
      builder.Append(this.mode_sequence);
      builder.Append("}");
      return builder.ToString();
   }
}


}