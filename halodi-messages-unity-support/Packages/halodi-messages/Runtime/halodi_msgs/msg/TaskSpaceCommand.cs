using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class TaskSpaceCommand : Halodi.CDR.DataType<TaskSpaceCommand>
{

	public Halodi.CDR.TopicDataType<TaskSpaceCommand> Type => new TaskSpaceCommandPubSubType();
	
   /**
                * Body Frame: The reference frame to control.
                *
                * Valid options are all frames that are "Controllable"
                *
                */
   public halodi_msgs.msg.ReferenceFrameName body_frame;
   /**
                * Expressed in frame: Origin of the command.
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
                * If true, the feedback controller controls the force acting on the end effector.
                * If false, the feedback controller controls the acceleration acting on the end effector.
                *
                * This could be used to implement force feedback control using an haptic actuator.
                * 
                * Note: Controlling acceleration results in a linear response with respect to the gains and is recommonded for normal use.
                *
                */
   public bool use_force_feedback;
   /**
                * 
                * Desired pose of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Pose pose;
   /**
                * 
                * Desired angular velocity of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Vector3 angular_velocity;
   /**
                * 
                * Desired linear velocity of the body frame, expressed in "expressed_in_frame"
                *
                */
   public geometry_msgs.msg.Vector3 linear_velocity;
   /**
                * Desired angular feedfordward term applied to the body frame, expressed in "expressed_in_frame"
                *
                * If use_force_feedback is false, this is feedforward angular acceleration (rad/s^2).
                * If use_force_feedback is true, this is feedforward torque (Nm).
                *
                */
   public geometry_msgs.msg.Vector3 angular_feedforward;
   /**
                * Desired linear feedfordward term applied to the body frame, expressed in "expressed_in_frame"
                *
                * If use_force_feedback is false, this is feedforward linear acceleration  (rad/s^2).
                * If use_force_feedback is true, this is feedforward force (N).
                *
                */
   public geometry_msgs.msg.Vector3 linear_feedforward;
   /**
                * (Optional) Energy input to the passivity layer.
                *
                * If not set, the passivity layer will be disabled.
                *
                */
   public System.Collections.Generic.List<double> energy_input;
   /**
                *
                * Angular feedback parameters
                *
                * Optional. When not provided, default values are used
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D> orientation_feedback_parameters;
   /**
                *
                * Linear feedback parameters
                *
                * Optional. When not provided, default values are used
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D> position_feedback_parameters;
   /**
                * Nullspace joint configuration 
                *
                */
   public System.Collections.Generic.List<halodi_msgs.msg.JointNullSpaceConfiguration> nullspace_command;


   public void Set(TaskSpaceCommand other)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.body_frame, body_frame);

      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.expressed_in_frame, expressed_in_frame);

      express_in_z_up = other.express_in_z_up;

      use_force_feedback = other.use_force_feedback;

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_velocity, angular_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_velocity, linear_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_feedforward, angular_feedforward);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_feedforward, linear_feedforward);


      if(other.energy_input == null)
      {
      	energy_input = null;
      }
      else
      {
      	energy_input = new System.Collections.Generic.List<double>(other.energy_input.Count);
      	for(int i1 = 0; i1 < other.energy_input.Count; i1++)
      	{
         		energy_input.Add(other.energy_input[i1]);
      	}
      }

      if(other.orientation_feedback_parameters == null)
      {
      	orientation_feedback_parameters = null;
      }
      else
      {
      	orientation_feedback_parameters = new System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D>(other.orientation_feedback_parameters.Count);
      	for(int i2 = 0; i2 < other.orientation_feedback_parameters.Count; i2++)
      	{
      		if(other.orientation_feedback_parameters[i2] == null)
      		{
      			orientation_feedback_parameters.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.FeedbackParameters3D newElement = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create();
      	   		halodi_msgs.msg.FeedbackParameters3DPubSubType.Copy(other.orientation_feedback_parameters[i2], newElement);
      	   		orientation_feedback_parameters.Add(newElement);
      		}	}
      }

      if(other.position_feedback_parameters == null)
      {
      	position_feedback_parameters = null;
      }
      else
      {
      	position_feedback_parameters = new System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D>(other.position_feedback_parameters.Count);
      	for(int i3 = 0; i3 < other.position_feedback_parameters.Count; i3++)
      	{
      		if(other.position_feedback_parameters[i3] == null)
      		{
      			position_feedback_parameters.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.FeedbackParameters3D newElement = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create();
      	   		halodi_msgs.msg.FeedbackParameters3DPubSubType.Copy(other.position_feedback_parameters[i3], newElement);
      	   		position_feedback_parameters.Add(newElement);
      		}	}
      }

      if(other.nullspace_command == null)
      {
      	nullspace_command = null;
      }
      else
      {
      	nullspace_command = new System.Collections.Generic.List<halodi_msgs.msg.JointNullSpaceConfiguration>(other.nullspace_command.Count);
      	for(int i4 = 0; i4 < other.nullspace_command.Count; i4++)
      	{
      		if(other.nullspace_command[i4] == null)
      		{
      			nullspace_command.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointNullSpaceConfiguration newElement = halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.Create();
      	   		halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.Copy(other.nullspace_command[i4], newElement);
      	   		nullspace_command.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TaskSpaceCommand {");
      builder.Append("body_frame=");
      builder.Append(this.body_frame);      builder.Append(", ");
      builder.Append("expressed_in_frame=");
      builder.Append(this.expressed_in_frame);      builder.Append(", ");
      builder.Append("express_in_z_up=");
      builder.Append(this.express_in_z_up);      builder.Append(", ");
      builder.Append("use_force_feedback=");
      builder.Append(this.use_force_feedback);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("angular_velocity=");
      builder.Append(this.angular_velocity);      builder.Append(", ");
      builder.Append("linear_velocity=");
      builder.Append(this.linear_velocity);      builder.Append(", ");
      builder.Append("angular_feedforward=");
      builder.Append(this.angular_feedforward);      builder.Append(", ");
      builder.Append("linear_feedforward=");
      builder.Append(this.linear_feedforward);      builder.Append(", ");
      builder.Append("energy_input=");
      builder.Append(this.energy_input);      builder.Append(", ");
      builder.Append("orientation_feedback_parameters=");
      builder.Append(this.orientation_feedback_parameters);      builder.Append(", ");
      builder.Append("position_feedback_parameters=");
      builder.Append(this.position_feedback_parameters);      builder.Append(", ");
      builder.Append("nullspace_command=");
      builder.Append(this.nullspace_command);
      builder.Append("}");
      return builder.ToString();
   }
}


}