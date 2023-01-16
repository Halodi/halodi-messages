using System.IO;
namespace ocs2_ros2_msgs.msg
{

/**
* 
* Topic data type of the struct "MpcPerformanceIndices" defined in "MpcPerformanceIndices.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MpcPerformanceIndices.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MpcPerformanceIndices.idl instead.
*
*/
public class MpcPerformanceIndicesPubSubType : Halodi.CDR.TopicDataType<MpcPerformanceIndices>
{
   public override string Name => "ocs2_ros2_msgs::msg::dds_::MpcPerformanceIndices_";


   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcPerformanceIndices data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_5(data.init_time);

      cdr.write_type_5(data.merit);

      cdr.write_type_5(data.cost);

      cdr.write_type_5(data.dynamics_violation_sse);

      cdr.write_type_5(data.equality_constraints_sse);

      cdr.write_type_5(data.equality_lagrangian);

      cdr.write_type_5(data.inequality_lagrangian);

   }

   public static void read(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.init_time=cdr.read_type_5();
      	
      data.merit=cdr.read_type_5();
      	
      data.cost=cdr.read_type_5();
      	
      data.dynamics_violation_sse=cdr.read_type_5();
      	
      data.equality_constraints_sse=cdr.read_type_5();
      	
      data.equality_lagrangian=cdr.read_type_5();
      	
      data.inequality_lagrangian=cdr.read_type_5();
      	

   }


	public override void Serialize(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(ocs2_ros2_msgs.msg.MpcPerformanceIndices data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(ocs2_ros2_msgs.msg.MpcPerformanceIndices src, ocs2_ros2_msgs.msg.MpcPerformanceIndices target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(ocs2_ros2_msgs.msg.MpcPerformanceIndices src, ocs2_ros2_msgs.msg.MpcPerformanceIndices target)
    {
    	Copy(src, target);
    }


}


}