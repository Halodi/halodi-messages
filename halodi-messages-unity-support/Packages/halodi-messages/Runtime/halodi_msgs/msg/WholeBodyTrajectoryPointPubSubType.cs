using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "WholeBodyTrajectoryPoint" defined in "WholeBodyTrajectoryPoint.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from WholeBodyTrajectoryPoint.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit WholeBodyTrajectoryPoint.idl instead.
*
*/
public class WholeBodyTrajectoryPointPubSubType : Halodi.CDR.TopicDataType<WholeBodyTrajectoryPoint>
{
   public override string Name => "halodi_msgs::msg::dds_::WholeBodyTrajectoryPoint_";


   
   public override void serialize(halodi_msgs.msg.WholeBodyTrajectoryPoint data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.WholeBodyTrajectoryPoint data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyTrajectoryPoint data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyTrajectoryPoint data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += builtin_interfaces.msg.DurationPubSubType.getCdrSerializedSize(data.time_from_start, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.task_space_commands.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.TaskSpaceCommandPubSubType.getCdrSerializedSize(data.task_space_commands[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joint_space_commands.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.JointSpaceCommandPubSubType.getCdrSerializedSize(data.joint_space_commands[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.contact_point_commands.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.ContactPointCommandPubSubType.getCdrSerializedSize(data.contact_point_commands[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.icp_offset_command.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.icp_offset_command[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.left_hand_command.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.HandCommandPubSubType.getCdrSerializedSize(data.left_hand_command[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.right_hand_command.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.HandCommandPubSubType.getCdrSerializedSize(data.right_hand_command[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.WholeBodyTrajectoryPoint data, Halodi.CDR.CDRSerializer cdr)
   {
      builtin_interfaces.msg.DurationPubSubType.write(data.time_from_start, cdr);

      	if(data.task_space_commands == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int task_space_commands_length = data.task_space_commands.Count;
            cdr.write_type_2(task_space_commands_length);
            for (int i0 = 0; i0 < task_space_commands_length; i0++)
            {
      			halodi_msgs.msg.TaskSpaceCommandPubSubType.write(data.task_space_commands[i0], cdr);	      }
        }
      	if(data.joint_space_commands == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joint_space_commands_length = data.joint_space_commands.Count;
            cdr.write_type_2(joint_space_commands_length);
            for (int i0 = 0; i0 < joint_space_commands_length; i0++)
            {
      			halodi_msgs.msg.JointSpaceCommandPubSubType.write(data.joint_space_commands[i0], cdr);	      }
        }
      	if(data.contact_point_commands == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int contact_point_commands_length = data.contact_point_commands.Count;
            cdr.write_type_2(contact_point_commands_length);
            for (int i0 = 0; i0 < contact_point_commands_length; i0++)
            {
      			halodi_msgs.msg.ContactPointCommandPubSubType.write(data.contact_point_commands[i0], cdr);	      }
        }
      	if(data.icp_offset_command == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int icp_offset_command_length = data.icp_offset_command.Count;
            cdr.write_type_2(icp_offset_command_length);
            for (int i0 = 0; i0 < icp_offset_command_length; i0++)
            {
      			geometry_msgs.msg.Vector3PubSubType.write(data.icp_offset_command[i0], cdr);	      }
        }
      	if(data.left_hand_command == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int left_hand_command_length = data.left_hand_command.Count;
            cdr.write_type_2(left_hand_command_length);
            for (int i0 = 0; i0 < left_hand_command_length; i0++)
            {
      			halodi_msgs.msg.HandCommandPubSubType.write(data.left_hand_command[i0], cdr);	      }
        }
      	if(data.right_hand_command == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int right_hand_command_length = data.right_hand_command.Count;
            cdr.write_type_2(right_hand_command_length);
            for (int i0 = 0; i0 < right_hand_command_length; i0++)
            {
      			halodi_msgs.msg.HandCommandPubSubType.write(data.right_hand_command[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.WholeBodyTrajectoryPoint data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.time_from_start = builtin_interfaces.msg.DurationPubSubType.Create();
      builtin_interfaces.msg.DurationPubSubType.read(data.time_from_start, cdr);
      	

      int task_space_commands_length = cdr.read_type_2();
      data.task_space_commands = new System.Collections.Generic.List<halodi_msgs.msg.TaskSpaceCommand>(task_space_commands_length);
      for(int i = 0; i < task_space_commands_length; i++)
      {
      	halodi_msgs.msg.TaskSpaceCommand new_task_space_commands = halodi_msgs.msg.TaskSpaceCommandPubSubType.Create(); 
      	halodi_msgs.msg.TaskSpaceCommandPubSubType.read(new_task_space_commands, cdr);
      	data.task_space_commands.Add(new_task_space_commands);	
      	
      }

      	

      int joint_space_commands_length = cdr.read_type_2();
      data.joint_space_commands = new System.Collections.Generic.List<halodi_msgs.msg.JointSpaceCommand>(joint_space_commands_length);
      for(int i = 0; i < joint_space_commands_length; i++)
      {
      	halodi_msgs.msg.JointSpaceCommand new_joint_space_commands = halodi_msgs.msg.JointSpaceCommandPubSubType.Create(); 
      	halodi_msgs.msg.JointSpaceCommandPubSubType.read(new_joint_space_commands, cdr);
      	data.joint_space_commands.Add(new_joint_space_commands);	
      	
      }

      	

      int contact_point_commands_length = cdr.read_type_2();
      data.contact_point_commands = new System.Collections.Generic.List<halodi_msgs.msg.ContactPointCommand>(contact_point_commands_length);
      for(int i = 0; i < contact_point_commands_length; i++)
      {
      	halodi_msgs.msg.ContactPointCommand new_contact_point_commands = halodi_msgs.msg.ContactPointCommandPubSubType.Create(); 
      	halodi_msgs.msg.ContactPointCommandPubSubType.read(new_contact_point_commands, cdr);
      	data.contact_point_commands.Add(new_contact_point_commands);	
      	
      }

      	

      int icp_offset_command_length = cdr.read_type_2();
      data.icp_offset_command = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(icp_offset_command_length);
      for(int i = 0; i < icp_offset_command_length; i++)
      {
      	geometry_msgs.msg.Vector3 new_icp_offset_command = geometry_msgs.msg.Vector3PubSubType.Create(); 
      	geometry_msgs.msg.Vector3PubSubType.read(new_icp_offset_command, cdr);
      	data.icp_offset_command.Add(new_icp_offset_command);	
      	
      }

      	

      int left_hand_command_length = cdr.read_type_2();
      data.left_hand_command = new System.Collections.Generic.List<halodi_msgs.msg.HandCommand>(left_hand_command_length);
      for(int i = 0; i < left_hand_command_length; i++)
      {
      	halodi_msgs.msg.HandCommand new_left_hand_command = halodi_msgs.msg.HandCommandPubSubType.Create(); 
      	halodi_msgs.msg.HandCommandPubSubType.read(new_left_hand_command, cdr);
      	data.left_hand_command.Add(new_left_hand_command);	
      	
      }

      	

      int right_hand_command_length = cdr.read_type_2();
      data.right_hand_command = new System.Collections.Generic.List<halodi_msgs.msg.HandCommand>(right_hand_command_length);
      for(int i = 0; i < right_hand_command_length; i++)
      {
      	halodi_msgs.msg.HandCommand new_right_hand_command = halodi_msgs.msg.HandCommandPubSubType.Create(); 
      	halodi_msgs.msg.HandCommandPubSubType.read(new_right_hand_command, cdr);
      	data.right_hand_command.Add(new_right_hand_command);	
      	
      }

      	

   }


    public static void Copy(halodi_msgs.msg.WholeBodyTrajectoryPoint src, halodi_msgs.msg.WholeBodyTrajectoryPoint target)
    {
        target.Set(src);
    }


}


}