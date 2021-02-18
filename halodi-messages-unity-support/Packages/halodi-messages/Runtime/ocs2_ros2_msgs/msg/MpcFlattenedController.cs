using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class MpcFlattenedController : Halodi.CDR.DataType<MpcFlattenedController>
{

	public Halodi.CDR.TopicDataType<MpcFlattenedController> Type => new MpcFlattenedControllerPubSubType();
	
   public const byte CONTROLLER_UNKNOWN = (byte) 0;
   public const byte CONTROLLER_FEEDFORWARD = (byte) 1;
   public const byte CONTROLLER_LINEAR = (byte) 2;
   public byte controller_type;
   public ocs2_ros2_msgs.msg.MpcObservation init_observation;
   public ocs2_ros2_msgs.msg.MpcTargetTrajectories plan_target_trajectories;
   public System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcState> state_trajectory;
   public System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcInput> input_trajectory;
   public System.Collections.Generic.List<float> time_trajectory;
   public ocs2_ros2_msgs.msg.ModeSchedule mode_schedule;
   public System.Collections.Generic.List<ocs2_ros2_msgs.msg.ControllerData> data;
   public ocs2_ros2_msgs.msg.MpcPerformanceIndices performance_indices;


   public void Set(MpcFlattenedController other)
   {
      controller_type = other.controller_type;

      ocs2_ros2_msgs.msg.MpcObservationPubSubType.Copy(other.init_observation, init_observation);

      ocs2_ros2_msgs.msg.MpcTargetTrajectoriesPubSubType.Copy(other.plan_target_trajectories, plan_target_trajectories);


      if(other.state_trajectory == null)
      {
      	state_trajectory = null;
      }
      else
      {
      	state_trajectory = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcState>(other.state_trajectory.Count);
      	for(int i1 = 0; i1 < other.state_trajectory.Count; i1++)
      	{
      		if(other.state_trajectory[i1] == null)
      		{
      			state_trajectory.Add(null);
      		}
      		else
      		{
      			ocs2_ros2_msgs.msg.MpcState newElement = ocs2_ros2_msgs.msg.MpcStatePubSubType.Create();
      	   		ocs2_ros2_msgs.msg.MpcStatePubSubType.Copy(other.state_trajectory[i1], newElement);
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
      	for(int i2 = 0; i2 < other.input_trajectory.Count; i2++)
      	{
      		if(other.input_trajectory[i2] == null)
      		{
      			input_trajectory.Add(null);
      		}
      		else
      		{
      			ocs2_ros2_msgs.msg.MpcInput newElement = ocs2_ros2_msgs.msg.MpcInputPubSubType.Create();
      	   		ocs2_ros2_msgs.msg.MpcInputPubSubType.Copy(other.input_trajectory[i2], newElement);
      	   		input_trajectory.Add(newElement);
      		}	}
      }

      if(other.time_trajectory == null)
      {
      	time_trajectory = null;
      }
      else
      {
      	time_trajectory = new System.Collections.Generic.List<float>(other.time_trajectory.Count);
      	for(int i3 = 0; i3 < other.time_trajectory.Count; i3++)
      	{
         		time_trajectory.Add(other.time_trajectory[i3]);
      	}
      }
      ocs2_ros2_msgs.msg.ModeSchedulePubSubType.Copy(other.mode_schedule, mode_schedule);


      if(other.data == null)
      {
      	data = null;
      }
      else
      {
      	data = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.ControllerData>(other.data.Count);
      	for(int i4 = 0; i4 < other.data.Count; i4++)
      	{
      		if(other.data[i4] == null)
      		{
      			data.Add(null);
      		}
      		else
      		{
      			ocs2_ros2_msgs.msg.ControllerData newElement = ocs2_ros2_msgs.msg.ControllerDataPubSubType.Create();
      	   		ocs2_ros2_msgs.msg.ControllerDataPubSubType.Copy(other.data[i4], newElement);
      	   		data.Add(newElement);
      		}	}
      }
      ocs2_ros2_msgs.msg.MpcPerformanceIndicesPubSubType.Copy(other.performance_indices, performance_indices);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MpcFlattenedController {");
      builder.Append("controller_type=");
      builder.Append(this.controller_type);      builder.Append(", ");
      builder.Append("init_observation=");
      builder.Append(this.init_observation);      builder.Append(", ");
      builder.Append("plan_target_trajectories=");
      builder.Append(this.plan_target_trajectories);      builder.Append(", ");
      builder.Append("state_trajectory=");
      builder.Append(this.state_trajectory);      builder.Append(", ");
      builder.Append("input_trajectory=");
      builder.Append(this.input_trajectory);      builder.Append(", ");
      builder.Append("time_trajectory=");
      builder.Append(this.time_trajectory);      builder.Append(", ");
      builder.Append("mode_schedule=");
      builder.Append(this.mode_schedule);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);      builder.Append(", ");
      builder.Append("performance_indices=");
      builder.Append(this.performance_indices);
      builder.Append("}");
      return builder.ToString();
   }
}


}