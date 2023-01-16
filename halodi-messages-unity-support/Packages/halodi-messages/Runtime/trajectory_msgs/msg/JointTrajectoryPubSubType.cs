using System.IO;
namespace trajectory_msgs.msg
{

/**
* 
* Topic data type of the struct "JointTrajectory" defined in "JointTrajectory.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointTrajectory.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointTrajectory.idl instead.
*
*/
public class JointTrajectoryPubSubType : Halodi.CDR.TopicDataType<JointTrajectory>
{
   public override string Name => "trajectory_msgs::msg::dds_::JointTrajectory_";


   public static int getCdrSerializedSize(trajectory_msgs.msg.JointTrajectory data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(trajectory_msgs.msg.JointTrajectory data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joint_names.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.joint_names[i0].Length + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.points.Count; ++i0)
      {
          current_alignment += trajectory_msgs.msg.JointTrajectoryPointPubSubType.getCdrSerializedSize(data.points[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(trajectory_msgs.msg.JointTrajectory data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.joint_names == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joint_names_length = data.joint_names.Count;
            cdr.write_type_2(joint_names_length);
            for (int i0 = 0; i0 < joint_names_length; i0++)
            {
      			cdr.write_type_d(data.joint_names[i0]);
            }
        }
      	if(data.points == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int points_length = data.points.Count;
            cdr.write_type_2(points_length);
            for (int i0 = 0; i0 < points_length; i0++)
            {
      			trajectory_msgs.msg.JointTrajectoryPointPubSubType.write(data.points[i0], cdr);	      }
        }
   }

   public static void read(trajectory_msgs.msg.JointTrajectory data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int joint_names_length = cdr.read_type_2();
      data.joint_names = new System.Collections.Generic.List<string>(joint_names_length);
      for(int i = 0; i < joint_names_length; i++)
      {
      	data.joint_names.Add(cdr.read_type_d());	
      	
      }

      	

      int points_length = cdr.read_type_2();
      data.points = new System.Collections.Generic.List<trajectory_msgs.msg.JointTrajectoryPoint>(points_length);
      for(int i = 0; i < points_length; i++)
      {
      	trajectory_msgs.msg.JointTrajectoryPoint new_points = trajectory_msgs.msg.JointTrajectoryPointPubSubType.Create(); 
      	trajectory_msgs.msg.JointTrajectoryPointPubSubType.read(new_points, cdr);
      	data.points.Add(new_points);	
      	
      }

      	

   }


	public override void Serialize(trajectory_msgs.msg.JointTrajectory data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(trajectory_msgs.msg.JointTrajectory data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(trajectory_msgs.msg.JointTrajectory data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(trajectory_msgs.msg.JointTrajectory src, trajectory_msgs.msg.JointTrajectory target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(trajectory_msgs.msg.JointTrajectory src, trajectory_msgs.msg.JointTrajectory target)
    {
    	Copy(src, target);
    }


}


}