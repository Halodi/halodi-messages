using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "PointField" defined in "PointField.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PointField.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PointField.idl instead.
*
*/
public class PointFieldPubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.PointField>
{
   public override string Name => "sensor_msgs::msg::dds_::PointField_";


   
   public override void serialize(sensor_msgs.msg.PointField data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.PointField data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.PointField data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.PointField data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.PointField data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.name);

      cdr.write_type_4(data.offset);

      cdr.write_type_9(data.datatype);

      cdr.write_type_4(data.count);

   }

   public static void read(sensor_msgs.msg.PointField data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.name = cdr.read_type_d();	
      data.offset=cdr.read_type_4();
      	
      data.datatype=cdr.read_type_9();
      	
      data.count=cdr.read_type_4();
      	

   }


    public static void Copy(sensor_msgs.msg.PointField src, sensor_msgs.msg.PointField target)
    {
        target.Set(src);
    }


}


}