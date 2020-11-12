using System.IO;
namespace trajectory_msgs.msg
{

/**
* 
* Topic data type of the struct "JointTrajectoryPoint" defined in "JointTrajectoryPoint.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointTrajectoryPoint.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointTrajectoryPoint.idl instead.
*
*/
public class JointTrajectoryPointPubSubType : Halodi.CDR.TopicDataType<trajectory_msgs.msg.JointTrajectoryPoint>
{
   public override string Name => "trajectory_msgs::msg::dds_::JointTrajectoryPoint_";


   
   public override void serialize(trajectory_msgs.msg.JointTrajectoryPoint data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, trajectory_msgs.msg.JointTrajectoryPoint data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(trajectory_msgs.msg.JointTrajectoryPoint data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(trajectory_msgs.msg.JointTrajectoryPoint data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.positions.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.velocities.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.accelerations.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.effort.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += builtin_interfaces.msg.DurationPubSubType.getCdrSerializedSize(data.time_from_start, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(trajectory_msgs.msg.JointTrajectoryPoint data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.positions == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int positions_length = data.positions.Count;
            cdr.write_type_2(positions_length);
            for (int i0 = 0; i0 < positions_length; i0++)
            {
      			cdr.write_type_6(data.positions[i0]);
            }
        }
      	if(data.velocities == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int velocities_length = data.velocities.Count;
            cdr.write_type_2(velocities_length);
            for (int i0 = 0; i0 < velocities_length; i0++)
            {
      			cdr.write_type_6(data.velocities[i0]);
            }
        }
      	if(data.accelerations == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int accelerations_length = data.accelerations.Count;
            cdr.write_type_2(accelerations_length);
            for (int i0 = 0; i0 < accelerations_length; i0++)
            {
      			cdr.write_type_6(data.accelerations[i0]);
            }
        }
      	if(data.effort == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int effort_length = data.effort.Count;
            cdr.write_type_2(effort_length);
            for (int i0 = 0; i0 < effort_length; i0++)
            {
      			cdr.write_type_6(data.effort[i0]);
            }
        }
      builtin_interfaces.msg.DurationPubSubType.write(data.time_from_start, cdr);

   }

   public static void read(trajectory_msgs.msg.JointTrajectoryPoint data, Halodi.CDR.CDRDeserializer cdr)
   {

      int positions_length = cdr.read_type_2();
      data.positions = new System.Collections.Generic.List<double>(positions_length);
      for(int i = 0; i < positions_length; i++)
      {
      	data.positions.Add(cdr.read_type_6());
      	
      	
      }

      	

      int velocities_length = cdr.read_type_2();
      data.velocities = new System.Collections.Generic.List<double>(velocities_length);
      for(int i = 0; i < velocities_length; i++)
      {
      	data.velocities.Add(cdr.read_type_6());
      	
      	
      }

      	

      int accelerations_length = cdr.read_type_2();
      data.accelerations = new System.Collections.Generic.List<double>(accelerations_length);
      for(int i = 0; i < accelerations_length; i++)
      {
      	data.accelerations.Add(cdr.read_type_6());
      	
      	
      }

      	

      int effort_length = cdr.read_type_2();
      data.effort = new System.Collections.Generic.List<double>(effort_length);
      for(int i = 0; i < effort_length; i++)
      {
      	data.effort.Add(cdr.read_type_6());
      	
      	
      }

      	
      data.time_from_start = builtin_interfaces.msg.DurationPubSubType.Create();
      builtin_interfaces.msg.DurationPubSubType.read(data.time_from_start, cdr);
      	

   }


    public static void Copy(trajectory_msgs.msg.JointTrajectoryPoint src, trajectory_msgs.msg.JointTrajectoryPoint target)
    {
        target.Set(src);
    }


}


}