using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "TaskSpaceCommand" defined in "TaskSpaceCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TaskSpaceCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TaskSpaceCommand.idl instead.
*
*/
public class TaskSpaceCommandPubSubType : Halodi.CDR.TopicDataType<TaskSpaceCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::TaskSpaceCommand_";


   
   public override void serialize(halodi_msgs.msg.TaskSpaceCommand data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.TaskSpaceCommand data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.TaskSpaceCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.TaskSpaceCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.ReferenceFrameNamePubSubType.getCdrSerializedSize(data.body_frame, current_alignment);

      current_alignment += halodi_msgs.msg.ReferenceFrameNamePubSubType.getCdrSerializedSize(data.expressed_in_frame, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.frame_offset, current_alignment);

      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular_velocity, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear_velocity, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.angular_acceleration, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.linear_acceleration, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.passivity_input.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.PassivityDataPubSubType.getCdrSerializedSize(data.passivity_input[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.orientation_feedback_parameters.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.FeedbackParameters3DPubSubType.getCdrSerializedSize(data.orientation_feedback_parameters[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.position_feedback_parameters.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.FeedbackParameters3DPubSubType.getCdrSerializedSize(data.position_feedback_parameters[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.nullspace_command.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.getCdrSerializedSize(data.nullspace_command[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.TaskSpaceCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.write(data.body_frame, cdr);

      halodi_msgs.msg.ReferenceFrameNamePubSubType.write(data.expressed_in_frame, cdr);

      cdr.write_type_7(data.express_in_z_up);

      geometry_msgs.msg.Vector3PubSubType.write(data.frame_offset, cdr);

      geometry_msgs.msg.PosePubSubType.write(data.pose, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.angular_velocity, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.linear_velocity, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.angular_acceleration, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.linear_acceleration, cdr);

      	if(data.passivity_input == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int passivity_input_length = data.passivity_input.Count;
            cdr.write_type_2(passivity_input_length);
            for (int i0 = 0; i0 < passivity_input_length; i0++)
            {
      			halodi_msgs.msg.PassivityDataPubSubType.write(data.passivity_input[i0], cdr);	      }
        }
      	if(data.orientation_feedback_parameters == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int orientation_feedback_parameters_length = data.orientation_feedback_parameters.Count;
            cdr.write_type_2(orientation_feedback_parameters_length);
            for (int i0 = 0; i0 < orientation_feedback_parameters_length; i0++)
            {
      			halodi_msgs.msg.FeedbackParameters3DPubSubType.write(data.orientation_feedback_parameters[i0], cdr);	      }
        }
      	if(data.position_feedback_parameters == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int position_feedback_parameters_length = data.position_feedback_parameters.Count;
            cdr.write_type_2(position_feedback_parameters_length);
            for (int i0 = 0; i0 < position_feedback_parameters_length; i0++)
            {
      			halodi_msgs.msg.FeedbackParameters3DPubSubType.write(data.position_feedback_parameters[i0], cdr);	      }
        }
      	if(data.nullspace_command == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int nullspace_command_length = data.nullspace_command.Count;
            cdr.write_type_2(nullspace_command_length);
            for (int i0 = 0; i0 < nullspace_command_length; i0++)
            {
      			halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.write(data.nullspace_command[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.TaskSpaceCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.body_frame = halodi_msgs.msg.ReferenceFrameNamePubSubType.Create();
      halodi_msgs.msg.ReferenceFrameNamePubSubType.read(data.body_frame, cdr);
      	
      data.expressed_in_frame = halodi_msgs.msg.ReferenceFrameNamePubSubType.Create();
      halodi_msgs.msg.ReferenceFrameNamePubSubType.read(data.expressed_in_frame, cdr);
      	
      data.express_in_z_up=cdr.read_type_7();
      	
      data.frame_offset = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.frame_offset, cdr);
      	
      data.pose = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.pose, cdr);
      	
      data.angular_velocity = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular_velocity, cdr);
      	
      data.linear_velocity = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear_velocity, cdr);
      	
      data.angular_acceleration = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.angular_acceleration, cdr);
      	
      data.linear_acceleration = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.linear_acceleration, cdr);
      	

      int passivity_input_length = cdr.read_type_2();
      data.passivity_input = new System.Collections.Generic.List<halodi_msgs.msg.PassivityData>(passivity_input_length);
      for(int i = 0; i < passivity_input_length; i++)
      {
      	halodi_msgs.msg.PassivityData new_passivity_input = halodi_msgs.msg.PassivityDataPubSubType.Create(); 
      	halodi_msgs.msg.PassivityDataPubSubType.read(new_passivity_input, cdr);
      	data.passivity_input.Add(new_passivity_input);	
      	
      }

      	

      int orientation_feedback_parameters_length = cdr.read_type_2();
      data.orientation_feedback_parameters = new System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D>(orientation_feedback_parameters_length);
      for(int i = 0; i < orientation_feedback_parameters_length; i++)
      {
      	halodi_msgs.msg.FeedbackParameters3D new_orientation_feedback_parameters = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create(); 
      	halodi_msgs.msg.FeedbackParameters3DPubSubType.read(new_orientation_feedback_parameters, cdr);
      	data.orientation_feedback_parameters.Add(new_orientation_feedback_parameters);	
      	
      }

      	

      int position_feedback_parameters_length = cdr.read_type_2();
      data.position_feedback_parameters = new System.Collections.Generic.List<halodi_msgs.msg.FeedbackParameters3D>(position_feedback_parameters_length);
      for(int i = 0; i < position_feedback_parameters_length; i++)
      {
      	halodi_msgs.msg.FeedbackParameters3D new_position_feedback_parameters = halodi_msgs.msg.FeedbackParameters3DPubSubType.Create(); 
      	halodi_msgs.msg.FeedbackParameters3DPubSubType.read(new_position_feedback_parameters, cdr);
      	data.position_feedback_parameters.Add(new_position_feedback_parameters);	
      	
      }

      	

      int nullspace_command_length = cdr.read_type_2();
      data.nullspace_command = new System.Collections.Generic.List<halodi_msgs.msg.JointNullSpaceConfiguration>(nullspace_command_length);
      for(int i = 0; i < nullspace_command_length; i++)
      {
      	halodi_msgs.msg.JointNullSpaceConfiguration new_nullspace_command = halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.Create(); 
      	halodi_msgs.msg.JointNullSpaceConfigurationPubSubType.read(new_nullspace_command, cdr);
      	data.nullspace_command.Add(new_nullspace_command);	
      	
      }

      	

   }


    public static void Copy(halodi_msgs.msg.TaskSpaceCommand src, halodi_msgs.msg.TaskSpaceCommand target)
    {
        target.Set(src);
    }


}


}