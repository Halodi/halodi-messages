using System.IO;
namespace ocs2_ros2_msgs.msg
{

/**
* 
* Topic data type of the struct "MpcObservation" defined in "MpcObservation.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MpcObservation.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MpcObservation.idl instead.
*
*/
public class MpcObservationPubSubType : Halodi.CDR.TopicDataType<MpcObservation>
{
   public override string Name => "ocs2_ros2_msgs::msg::dds_::MpcObservation_";


   
   public override void serialize(ocs2_ros2_msgs.msg.MpcObservation data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, ocs2_ros2_msgs.msg.MpcObservation data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcObservation data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcObservation data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += ocs2_ros2_msgs.msg.MpcStatePubSubType.getCdrSerializedSize(data.state, current_alignment);

      current_alignment += ocs2_ros2_msgs.msg.MpcInputPubSubType.getCdrSerializedSize(data.input, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.MpcObservation data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_5(data.time);

      ocs2_ros2_msgs.msg.MpcStatePubSubType.write(data.state, cdr);

      ocs2_ros2_msgs.msg.MpcInputPubSubType.write(data.input, cdr);

      cdr.write_type_9(data.mode);

   }

   public static void read(ocs2_ros2_msgs.msg.MpcObservation data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.time=cdr.read_type_5();
      	
      data.state = ocs2_ros2_msgs.msg.MpcStatePubSubType.Create();
      ocs2_ros2_msgs.msg.MpcStatePubSubType.read(data.state, cdr);
      	
      data.input = ocs2_ros2_msgs.msg.MpcInputPubSubType.Create();
      ocs2_ros2_msgs.msg.MpcInputPubSubType.read(data.input, cdr);
      	
      data.mode=cdr.read_type_9();
      	

   }


    public static void Copy(ocs2_ros2_msgs.msg.MpcObservation src, ocs2_ros2_msgs.msg.MpcObservation target)
    {
        target.Set(src);
    }


}


}