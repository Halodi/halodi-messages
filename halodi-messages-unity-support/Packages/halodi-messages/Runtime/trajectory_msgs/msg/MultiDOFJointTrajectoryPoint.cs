using System.Text;
namespace trajectory_msgs.msg
{


[System.Serializable]
public class MultiDOFJointTrajectoryPoint
{
   /**
            * Each multi-dof joint can specify a transform (up to 6 DOF).
            */
   public System.Collections.Generic.List<geometry_msgs.msg.Transform> transforms;
   /**
            * There can be a velocity specified for the origin of the joint.
            */
   public System.Collections.Generic.List<geometry_msgs.msg.Twist> velocities;
   /**
            * There can be an acceleration specified for the origin of the joint.
            */
   public System.Collections.Generic.List<geometry_msgs.msg.Twist> accelerations;
   public builtin_interfaces.msg.Duration time_from_start;


   public void Set(MultiDOFJointTrajectoryPoint other)
   {

      if(other.transforms == null)
      {
      	transforms = null;
      }
      else
      {
      	transforms = new System.Collections.Generic.List<geometry_msgs.msg.Transform>(other.transforms.Count);
      	for(int i1 = 0; i1 < other.transforms.Count; i1++)
      	{
      		if(other.transforms[i1] == null)
      		{
      			transforms.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Transform newElement = geometry_msgs.msg.TransformPubSubType.Create();
      	   		geometry_msgs.msg.TransformPubSubType.Copy(other.transforms[i1], newElement);
      	   		transforms.Add(newElement);
      		}	}
      }

      if(other.velocities == null)
      {
      	velocities = null;
      }
      else
      {
      	velocities = new System.Collections.Generic.List<geometry_msgs.msg.Twist>(other.velocities.Count);
      	for(int i2 = 0; i2 < other.velocities.Count; i2++)
      	{
      		if(other.velocities[i2] == null)
      		{
      			velocities.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Twist newElement = geometry_msgs.msg.TwistPubSubType.Create();
      	   		geometry_msgs.msg.TwistPubSubType.Copy(other.velocities[i2], newElement);
      	   		velocities.Add(newElement);
      		}	}
      }

      if(other.accelerations == null)
      {
      	accelerations = null;
      }
      else
      {
      	accelerations = new System.Collections.Generic.List<geometry_msgs.msg.Twist>(other.accelerations.Count);
      	for(int i3 = 0; i3 < other.accelerations.Count; i3++)
      	{
      		if(other.accelerations[i3] == null)
      		{
      			accelerations.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Twist newElement = geometry_msgs.msg.TwistPubSubType.Create();
      	   		geometry_msgs.msg.TwistPubSubType.Copy(other.accelerations[i3], newElement);
      	   		accelerations.Add(newElement);
      		}	}
      }
      builtin_interfaces.msg.DurationPubSubType.Copy(other.time_from_start, time_from_start);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MultiDOFJointTrajectoryPoint {");
      builder.Append("transforms=");
      builder.Append(this.transforms);      builder.Append(", ");
      builder.Append("velocities=");
      builder.Append(this.velocities);      builder.Append(", ");
      builder.Append("accelerations=");
      builder.Append(this.accelerations);      builder.Append(", ");
      builder.Append("time_from_start=");
      builder.Append(this.time_from_start);
      builder.Append("}");
      return builder.ToString();
   }
}


}