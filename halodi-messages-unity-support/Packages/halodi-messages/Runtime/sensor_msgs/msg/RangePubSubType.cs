using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "Range" defined in "Range.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Range.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Range.idl instead.
*
*/
public class RangePubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.Range>
{
   public override string Name => "sensor_msgs::msg::dds_::Range_";


   
   public override void serialize(sensor_msgs.msg.Range data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.Range data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Range data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Range data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.Range data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_9(data.radiation_type);

      cdr.write_type_5(data.field_of_view);

      cdr.write_type_5(data.min_range);

      cdr.write_type_5(data.max_range);

      cdr.write_type_5(data.range);

   }

   public static void read(sensor_msgs.msg.Range data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.radiation_type=cdr.read_type_9();
      	
      data.field_of_view=cdr.read_type_5();
      	
      data.min_range=cdr.read_type_5();
      	
      data.max_range=cdr.read_type_5();
      	
      data.range=cdr.read_type_5();
      	

   }


    public static void Copy(sensor_msgs.msg.Range src, sensor_msgs.msg.Range target)
    {
        target.Set(src);
    }


}


}