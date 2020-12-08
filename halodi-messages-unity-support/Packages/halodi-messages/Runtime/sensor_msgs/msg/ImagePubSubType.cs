using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "Image" defined in "Image.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Image.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Image.idl instead.
*
*/
public class ImagePubSubType : Halodi.CDR.TopicDataType<Image>
{
   public override string Name => "sensor_msgs::msg::dds_::Image_";


   
   public override void serialize(sensor_msgs.msg.Image data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.Image data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Image data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Image data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.encoding.Length + 1;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.data.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.Image data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_4(data.height);

      cdr.write_type_4(data.width);

      cdr.write_type_d(data.encoding);

      cdr.write_type_9(data.is_bigendian);

      cdr.write_type_4(data.step);

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

   public static void read(sensor_msgs.msg.Image data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.height=cdr.read_type_4();
      	
      data.width=cdr.read_type_4();
      	
      data.encoding = cdr.read_type_d();	
      data.is_bigendian=cdr.read_type_9();
      	
      data.step=cdr.read_type_4();
      	

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<byte>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	data.data.Add(cdr.read_type_9());
      	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.Image src, sensor_msgs.msg.Image target)
    {
        target.Set(src);
    }


}


}