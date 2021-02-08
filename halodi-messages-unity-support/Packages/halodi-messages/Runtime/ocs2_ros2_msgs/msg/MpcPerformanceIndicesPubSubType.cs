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


   
   public override void serialize(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, ocs2_ros2_msgs.msg.MpcPerformanceIndices data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

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


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_5(data.init_time);

      cdr.write_type_5(data.merit);

      cdr.write_type_5(data.total_cost);

      cdr.write_type_5(data.state_eq_constraint_ise);

      cdr.write_type_5(data.state_eq_constraint_penalty);

      cdr.write_type_5(data.state_eq_finalconstraint_sse);

      cdr.write_type_5(data.state_eq_finalconstraint_penalty);

      cdr.write_type_5(data.state_input_eq_constraint_ise);

      cdr.write_type_5(data.inequality_constraint_ise);

      cdr.write_type_5(data.inequality_constraint_penalty);

   }

   public static void read(ocs2_ros2_msgs.msg.MpcPerformanceIndices data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.init_time=cdr.read_type_5();
      	
      data.merit=cdr.read_type_5();
      	
      data.total_cost=cdr.read_type_5();
      	
      data.state_eq_constraint_ise=cdr.read_type_5();
      	
      data.state_eq_constraint_penalty=cdr.read_type_5();
      	
      data.state_eq_finalconstraint_sse=cdr.read_type_5();
      	
      data.state_eq_finalconstraint_penalty=cdr.read_type_5();
      	
      data.state_input_eq_constraint_ise=cdr.read_type_5();
      	
      data.inequality_constraint_ise=cdr.read_type_5();
      	
      data.inequality_constraint_penalty=cdr.read_type_5();
      	

   }


    public static void Copy(ocs2_ros2_msgs.msg.MpcPerformanceIndices src, ocs2_ros2_msgs.msg.MpcPerformanceIndices target)
    {
        target.Set(src);
    }


}


}