using System.Text;
namespace halodi_msgs.msg
{


/**
          * Taskspace trajectory
          *
          * Contains a sequence of task space objectives to execute.
          * 
          */
[System.Serializable]
public class WholeBodyTrajectory
{
   /**
                 * A unique identifier for this message.
                 *
                 * This id is used to generate action_msgs::msg::GoalInfo status updates about the trajectory.
                 *
                 * When set to zero, no goalinfo messages are generated
                 *
                 */
   public unique_identifier_msgs.msg.UUID trajectory_id;
   /**
                 * (Optional) Time when to start executing this trajectory
                 *
                 *
                 * When ommitted, start_time depends on the value of append_trajectory
                 * - append_trajectory = true: start_time is the time for the last executed point. If the trajectory buffer is empty, start_time is now.
                 * - append_trajectory = false: start_time is now.
                 *
                 */
   public System.Collections.Generic.List<builtin_interfaces.msg.Time> start_time;
   /**
                 *
                 * (Optional, default AUTOMATIC) Balance mode to use.
                 * 
                 * The balance mode stays active even after the trajectory is finished (!)
                 * 
                 * When set to disabled, it is possible to enable/disable contact points. However the robot will be very unstable when standing without extra support.
                 *
                 */
   public System.Collections.Generic.List<halodi_msgs.msg.BalanceMode> balance_mode;
   /**
                 * Append this trajectory to the existing trajectory
                 * 
                 * If set to false, the existing trajectory is cancelled and this trajectory is immediatly executed.
                 * If set to false AND use_absolute_time is false, time is relative to now.
                 * 
                 * If set to true AND use_absolute_time is set to true, the time of the first point is required to be later than the last point in the buffer.
                 * If set to true AND use_absolute_time is false, the time is taken as relative to the latest point in the buffer. If the buffer is empty time is relative to now.
                 *
                 */
   public bool append_trajectory;
   /**
                 * Interpolation mode
                 * 
                 * Specifies how the trajectory is interpolated from the previous objective
                 *
                 */
   public halodi_msgs.msg.TrajectoryInterpolation interpolation_mode;
   /**
                 *
                 * Sequence of trajectory points. 
                 * 
                 * Each trajectory point should contain the same set of task space commands.
                 *
                 */
   public System.Collections.Generic.List<halodi_msgs.msg.WholeBodyTrajectoryPoint> trajectory_points;


   public void Set(WholeBodyTrajectory other)
   {
      unique_identifier_msgs.msg.UUIDPubSubType.Copy(other.trajectory_id, trajectory_id);


      if(other.start_time == null)
      {
      	start_time = null;
      }
      else
      {
      	start_time = new System.Collections.Generic.List<builtin_interfaces.msg.Time>(other.start_time.Count);
      	for(int i1 = 0; i1 < other.start_time.Count; i1++)
      	{
      		if(other.start_time[i1] == null)
      		{
      			start_time.Add(null);
      		}
      		else
      		{
      			builtin_interfaces.msg.Time newElement = builtin_interfaces.msg.TimePubSubType.Create();
      	   		builtin_interfaces.msg.TimePubSubType.Copy(other.start_time[i1], newElement);
      	   		start_time.Add(newElement);
      		}	}
      }

      if(other.balance_mode == null)
      {
      	balance_mode = null;
      }
      else
      {
      	balance_mode = new System.Collections.Generic.List<halodi_msgs.msg.BalanceMode>(other.balance_mode.Count);
      	for(int i2 = 0; i2 < other.balance_mode.Count; i2++)
      	{
      		if(other.balance_mode[i2] == null)
      		{
      			balance_mode.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.BalanceMode newElement = halodi_msgs.msg.BalanceModePubSubType.Create();
      	   		halodi_msgs.msg.BalanceModePubSubType.Copy(other.balance_mode[i2], newElement);
      	   		balance_mode.Add(newElement);
      		}	}
      }
      append_trajectory = other.append_trajectory;

      halodi_msgs.msg.TrajectoryInterpolationPubSubType.Copy(other.interpolation_mode, interpolation_mode);


      if(other.trajectory_points == null)
      {
      	trajectory_points = null;
      }
      else
      {
      	trajectory_points = new System.Collections.Generic.List<halodi_msgs.msg.WholeBodyTrajectoryPoint>(other.trajectory_points.Count);
      	for(int i3 = 0; i3 < other.trajectory_points.Count; i3++)
      	{
      		if(other.trajectory_points[i3] == null)
      		{
      			trajectory_points.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.WholeBodyTrajectoryPoint newElement = halodi_msgs.msg.WholeBodyTrajectoryPointPubSubType.Create();
      	   		halodi_msgs.msg.WholeBodyTrajectoryPointPubSubType.Copy(other.trajectory_points[i3], newElement);
      	   		trajectory_points.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("WholeBodyTrajectory {");
      builder.Append("trajectory_id=");
      builder.Append(this.trajectory_id);      builder.Append(", ");
      builder.Append("start_time=");
      builder.Append(this.start_time);      builder.Append(", ");
      builder.Append("balance_mode=");
      builder.Append(this.balance_mode);      builder.Append(", ");
      builder.Append("append_trajectory=");
      builder.Append(this.append_trajectory);      builder.Append(", ");
      builder.Append("interpolation_mode=");
      builder.Append(this.interpolation_mode);      builder.Append(", ");
      builder.Append("trajectory_points=");
      builder.Append(this.trajectory_points);
      builder.Append("}");
      return builder.ToString();
   }
}


}