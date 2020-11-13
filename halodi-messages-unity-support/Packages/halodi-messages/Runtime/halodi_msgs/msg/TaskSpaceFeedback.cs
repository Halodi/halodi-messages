using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class TaskSpaceFeedback : Halodi.CDR.DataType<TaskSpaceFeedback>
{

	public Halodi.CDR.TopicDataType<TaskSpaceFeedback> Type => new TaskSpaceFeedbackPubSubType();
	
   /**
                * Body Frame: The reference frame that is being controlled.
                *
                * Valid options are all frames that are "Controllable"
                *
                */
   public halodi_msgs.msg.ReferenceFrameName body_frame;
   /**
                * Expressed in frame: Origin of the feedback.
                *
                * Valid options are all frames that are "Expressable in"
                *
                */
   public halodi_msgs.msg.ReferenceFrameName expressed_in_frame;
   /**
                * Align the orientation of the expressed in frame such that z-axis points up. 
                * 
                * The heading (also known as yaw or the rotation around the z-axis) and position match the expressed_in_frame.
                *
                * This can be useful for keeping an end effector aligned with gravity while moving.
                * 
                */
   public bool express_in_z_up;
   /**
                 *
                 * If true, the feedback controller controls the force acting on the end effector. 
                 * If false, the feedback controller controls acceleration.
                 *
                 */
   public bool using_force_feedback;
   /**
                * Desired angular effort applied on the body frame, expressed in "expressed_in_frame"
                *
                * If using_force_feedback is false, this is angular acceleration (rad/s^2).
                * If using_force_feedback is true, this is torque (Nm).
                *
                */
   public geometry_msgs.msg.Vector3 angular_effort;
   /**
                * Desired linear effort applied on the body frame, expressed in "expressed_in_frame"
                *
                * If using_force_feedback is false, this is linear acceleration (rad/s^2).
                * If using_force_feedback is true, this is force (N).
                *
                */
   public geometry_msgs.msg.Vector3 linear_effort;
   /** 
                * (Optional) Energy output from passivity layer
                * 
                * If not set, the passivity layer is disabled. 
                *
                */
   public System.Collections.Generic.List<double> energy_output;
   /**
                 * (Optional) Tank level from the passivity layer.
                 *
                 * If not set, the passivity layer is disabled. 
                 */
   public System.Collections.Generic.List<double> energy_tank_level;


   public void Set(TaskSpaceFeedback other)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.body_frame, body_frame);

      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.expressed_in_frame, expressed_in_frame);

      express_in_z_up = other.express_in_z_up;

      using_force_feedback = other.using_force_feedback;

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_effort, angular_effort);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_effort, linear_effort);


      if(other.energy_output == null)
      {
      	energy_output = null;
      }
      else
      {
      	energy_output = new System.Collections.Generic.List<double>(other.energy_output.Count);
      	for(int i1 = 0; i1 < other.energy_output.Count; i1++)
      	{
         		energy_output.Add(other.energy_output[i1]);
      	}
      }

      if(other.energy_tank_level == null)
      {
      	energy_tank_level = null;
      }
      else
      {
      	energy_tank_level = new System.Collections.Generic.List<double>(other.energy_tank_level.Count);
      	for(int i2 = 0; i2 < other.energy_tank_level.Count; i2++)
      	{
         		energy_tank_level.Add(other.energy_tank_level[i2]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TaskSpaceFeedback {");
      builder.Append("body_frame=");
      builder.Append(this.body_frame);      builder.Append(", ");
      builder.Append("expressed_in_frame=");
      builder.Append(this.expressed_in_frame);      builder.Append(", ");
      builder.Append("express_in_z_up=");
      builder.Append(this.express_in_z_up);      builder.Append(", ");
      builder.Append("using_force_feedback=");
      builder.Append(this.using_force_feedback);      builder.Append(", ");
      builder.Append("angular_effort=");
      builder.Append(this.angular_effort);      builder.Append(", ");
      builder.Append("linear_effort=");
      builder.Append(this.linear_effort);      builder.Append(", ");
      builder.Append("energy_output=");
      builder.Append(this.energy_output);      builder.Append(", ");
      builder.Append("energy_tank_level=");
      builder.Append(this.energy_tank_level);
      builder.Append("}");
      return builder.ToString();
   }
}


}