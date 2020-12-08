using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class MpcTargetTrajectories : Halodi.CDR.DataType<MpcTargetTrajectories>
{

	public Halodi.CDR.TopicDataType<MpcTargetTrajectories> Type => new MpcTargetTrajectoriesPubSubType();
	
   public System.Collections.Generic.List<float> time_trajectory;
   public System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcState> state_trajectory;
   public System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcInput> input_trajectory;


   public void Set(MpcTargetTrajectories other)
   {

      if(other.time_trajectory == null)
      {
      	time_trajectory = null;
      }
      else
      {
      	time_trajectory = new System.Collections.Generic.List<float>(other.time_trajectory.Count);
      	for(int i1 = 0; i1 < other.time_trajectory.Count; i1++)
      	{
         		time_trajectory.Add(other.time_trajectory[i1]);
      	}
      }

      if(other.state_trajectory == null)
      {
      	state_trajectory = null;
      }
      else
      {
      	state_trajectory = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcState>(other.state_trajectory.Count);
      	for(int i2 = 0; i2 < other.state_trajectory.Count; i2++)
      	{
      		if(other.state_trajectory[i2] == null)
      		{
      			state_trajectory.Add(null);
      		}
      		else
      		{
      			ocs2_ros2_msgs.msg.MpcState newElement = ocs2_ros2_msgs.msg.MpcStatePubSubType.Create();
      	   		ocs2_ros2_msgs.msg.MpcStatePubSubType.Copy(other.state_trajectory[i2], newElement);
      	   		state_trajectory.Add(newElement);
      		}	}
      }

      if(other.input_trajectory == null)
      {
      	input_trajectory = null;
      }
      else
      {
      	input_trajectory = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcInput>(other.input_trajectory.Count);
      	for(int i3 = 0; i3 < other.input_trajectory.Count; i3++)
      	{
      		if(other.input_trajectory[i3] == null)
      		{
      			input_trajectory.Add(null);
      		}
      		else
      		{
      			ocs2_ros2_msgs.msg.MpcInput newElement = ocs2_ros2_msgs.msg.MpcInputPubSubType.Create();
      	   		ocs2_ros2_msgs.msg.MpcInputPubSubType.Copy(other.input_trajectory[i3], newElement);
      	   		input_trajectory.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MpcTargetTrajectories {");
      builder.Append("time_trajectory=");
      builder.Append(this.time_trajectory);      builder.Append(", ");
      builder.Append("state_trajectory=");
      builder.Append(this.state_trajectory);      builder.Append(", ");
      builder.Append("input_trajectory=");
      builder.Append(this.input_trajectory);
      builder.Append("}");
      return builder.ToString();
   }
}


}