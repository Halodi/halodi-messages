using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "JoyFeedback" defined in "JoyFeedback.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JoyFeedback.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JoyFeedback.idl instead.
*
*/
public class JoyFeedbackPubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.JoyFeedback>
{
   public override string Name => "sensor_msgs::msg::dds_::JoyFeedback_";


   
   public override void serialize(sensor_msgs.msg.JoyFeedback data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.JoyFeedback data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.JoyFeedback data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.JoyFeedback data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.JoyFeedback data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.type);

      cdr.write_type_9(data.id);

      cdr.write_type_5(data.intensity);

   }

   public static void read(sensor_msgs.msg.JoyFeedback data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.type=cdr.read_type_9();
      	
      data.id=cdr.read_type_9();
      	
      data.intensity=cdr.read_type_5();
      	

   }


    public static void Copy(sensor_msgs.msg.JoyFeedback src, sensor_msgs.msg.JoyFeedback target)
    {
        target.Set(src);
    }


}


}