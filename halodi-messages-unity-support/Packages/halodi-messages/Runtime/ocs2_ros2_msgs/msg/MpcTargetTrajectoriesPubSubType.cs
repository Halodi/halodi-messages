using System.IO;
namespace ocs2_ros2_msgs.msg
{

/**
* 
* Topic data type of the struct "MpcTargetTrajectories" defined in "MpcTargetTrajectories.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MpcTargetTrajectories.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MpcTargetTrajectories.idl instead.
*
*/
public class MpcTargetTrajectoriesPubSubType : Halodi.CDR.TopicDataType<MpcTargetTrajectories>
{
   public override string Name => "ocs2_ros2_msgs::msg::dds_::MpcTargetTrajectories_";


   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcTargetTrajectories data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcTargetTrajectories data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.time_trajectory.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.state_trajectory.Count; ++i0)
      {
          current_alignment += ocs2_ros2_msgs.msg.MpcStatePubSubType.getCdrSerializedSize(data.state_trajectory[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.input_trajectory.Count; ++i0)
      {
          current_alignment += ocs2_ros2_msgs.msg.MpcInputPubSubType.getCdrSerializedSize(data.input_trajectory[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.MpcTargetTrajectories data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.api_version);

      	if(data.time_trajectory == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int time_trajectory_length = data.time_trajectory.Count;
            cdr.write_type_2(time_trajectory_length);
            for (int i0 = 0; i0 < time_trajectory_length; i0++)
            {
      			cdr.write_type_5(data.time_trajectory[i0]);
            }
        }
      	if(data.state_trajectory == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int state_trajectory_length = data.state_trajectory.Count;
            cdr.write_type_2(state_trajectory_length);
            for (int i0 = 0; i0 < state_trajectory_length; i0++)
            {
      			ocs2_ros2_msgs.msg.MpcStatePubSubType.write(data.state_trajectory[i0], cdr);	      }
        }
      	if(data.input_trajectory == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int input_trajectory_length = data.input_trajectory.Count;
            cdr.write_type_2(input_trajectory_length);
            for (int i0 = 0; i0 < input_trajectory_length; i0++)
            {
      			ocs2_ros2_msgs.msg.MpcInputPubSubType.write(data.input_trajectory[i0], cdr);	      }
        }
   }

   public static void read(ocs2_ros2_msgs.msg.MpcTargetTrajectories data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.api_version=cdr.read_type_2();
      	

      int time_trajectory_length = cdr.read_type_2();
      data.time_trajectory = new System.Collections.Generic.List<float>(time_trajectory_length);
      for(int i = 0; i < time_trajectory_length; i++)
      {
      	data.time_trajectory.Add(cdr.read_type_5());
      	
      	
      }

      	

      int state_trajectory_length = cdr.read_type_2();
      data.state_trajectory = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcState>(state_trajectory_length);
      for(int i = 0; i < state_trajectory_length; i++)
      {
      	ocs2_ros2_msgs.msg.MpcState new_state_trajectory = ocs2_ros2_msgs.msg.MpcStatePubSubType.Create(); 
      	ocs2_ros2_msgs.msg.MpcStatePubSubType.read(new_state_trajectory, cdr);
      	data.state_trajectory.Add(new_state_trajectory);	
      	
      }

      	

      int input_trajectory_length = cdr.read_type_2();
      data.input_trajectory = new System.Collections.Generic.List<ocs2_ros2_msgs.msg.MpcInput>(input_trajectory_length);
      for(int i = 0; i < input_trajectory_length; i++)
      {
      	ocs2_ros2_msgs.msg.MpcInput new_input_trajectory = ocs2_ros2_msgs.msg.MpcInputPubSubType.Create(); 
      	ocs2_ros2_msgs.msg.MpcInputPubSubType.read(new_input_trajectory, cdr);
      	data.input_trajectory.Add(new_input_trajectory);	
      	
      }

      	

   }


	public override void Serialize(ocs2_ros2_msgs.msg.MpcTargetTrajectories data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(ocs2_ros2_msgs.msg.MpcTargetTrajectories data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(ocs2_ros2_msgs.msg.MpcTargetTrajectories data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(ocs2_ros2_msgs.msg.MpcTargetTrajectories src, ocs2_ros2_msgs.msg.MpcTargetTrajectories target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(ocs2_ros2_msgs.msg.MpcTargetTrajectories src, ocs2_ros2_msgs.msg.MpcTargetTrajectories target)
    {
    	Copy(src, target);
    }


}


}