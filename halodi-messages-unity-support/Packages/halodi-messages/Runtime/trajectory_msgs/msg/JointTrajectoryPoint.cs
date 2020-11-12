using System.Text;
namespace trajectory_msgs.msg
{


/**
       * Each trajectory point specifies either positions[, velocities[, accelerations]]
       * or positions[, effort] for the trajectory to be executed.
       * All specified values are in the same order as the joint names in JointTrajectory.msg.
       */
[System.Serializable]
public class JointTrajectoryPoint
{
   public System.Collections.Generic.List<double> positions;
   public System.Collections.Generic.List<double> velocities;
   public System.Collections.Generic.List<double> accelerations;
   public System.Collections.Generic.List<double> effort;
   public builtin_interfaces.msg.Duration time_from_start;


   public void Set(JointTrajectoryPoint other)
   {

      if(other.positions == null)
      {
      	positions = null;
      }
      else
      {
      	positions = new System.Collections.Generic.List<double>(other.positions.Count);
      	for(int i1 = 0; i1 < other.positions.Count; i1++)
      	{
         		positions.Add(other.positions[i1]);
      	}
      }

      if(other.velocities == null)
      {
      	velocities = null;
      }
      else
      {
      	velocities = new System.Collections.Generic.List<double>(other.velocities.Count);
      	for(int i2 = 0; i2 < other.velocities.Count; i2++)
      	{
         		velocities.Add(other.velocities[i2]);
      	}
      }

      if(other.accelerations == null)
      {
      	accelerations = null;
      }
      else
      {
      	accelerations = new System.Collections.Generic.List<double>(other.accelerations.Count);
      	for(int i3 = 0; i3 < other.accelerations.Count; i3++)
      	{
         		accelerations.Add(other.accelerations[i3]);
      	}
      }

      if(other.effort == null)
      {
      	effort = null;
      }
      else
      {
      	effort = new System.Collections.Generic.List<double>(other.effort.Count);
      	for(int i4 = 0; i4 < other.effort.Count; i4++)
      	{
         		effort.Add(other.effort[i4]);
      	}
      }
      builtin_interfaces.msg.DurationPubSubType.Copy(other.time_from_start, time_from_start);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointTrajectoryPoint {");
      builder.Append("positions=");
      builder.Append(this.positions);      builder.Append(", ");
      builder.Append("velocities=");
      builder.Append(this.velocities);      builder.Append(", ");
      builder.Append("accelerations=");
      builder.Append(this.accelerations);      builder.Append(", ");
      builder.Append("effort=");
      builder.Append(this.effort);      builder.Append(", ");
      builder.Append("time_from_start=");
      builder.Append(this.time_from_start);
      builder.Append("}");
      return builder.ToString();
   }
}


}