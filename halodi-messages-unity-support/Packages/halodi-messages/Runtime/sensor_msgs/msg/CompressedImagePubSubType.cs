using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "CompressedImage" defined in "CompressedImage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from CompressedImage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit CompressedImage.idl instead.
*
*/
public class CompressedImagePubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.CompressedImage>
{
   public override string Name => "sensor_msgs::msg::dds_::CompressedImage_";


   
   public override void serialize(sensor_msgs.msg.CompressedImage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.CompressedImage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.CompressedImage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.CompressedImage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.format.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.data.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.CompressedImage data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_d(data.format);

      	if(data.data == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int data_length = data.data.Count;
            cdr.write_type_2(data_length);
            for (int i0 = 0; i0 < data_length; i0++)
            {
      			cdr.write_type_9(data.data[i0]);
            }
        }
   }

   public static void read(sensor_msgs.msg.CompressedImage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.format = cdr.read_type_d();	

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<byte>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	data.data.Add(cdr.read_type_9());
      	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.CompressedImage src, sensor_msgs.msg.CompressedImage target)
    {
        target.Set(src);
    }


}


}