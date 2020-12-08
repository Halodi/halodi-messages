using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "ChannelFloat32" defined in "ChannelFloat32.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ChannelFloat32.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ChannelFloat32.idl instead.
*
*/
public class ChannelFloat32PubSubType : Halodi.CDR.TopicDataType<ChannelFloat32>
{
   public override string Name => "sensor_msgs::msg::dds_::ChannelFloat32_";


   
   public override void serialize(sensor_msgs.msg.ChannelFloat32 data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.ChannelFloat32 data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.ChannelFloat32 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.ChannelFloat32 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.values.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.ChannelFloat32 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.name);

      	if(data.values == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int values_length = data.values.Count;
            cdr.write_type_2(values_length);
            for (int i0 = 0; i0 < values_length; i0++)
            {
      			cdr.write_type_5(data.values[i0]);
            }
        }
   }

   public static void read(sensor_msgs.msg.ChannelFloat32 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.name = cdr.read_type_d();	

      int values_length = cdr.read_type_2();
      data.values = new System.Collections.Generic.List<float>(values_length);
      for(int i = 0; i < values_length; i++)
      {
      	data.values.Add(cdr.read_type_5());
      	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.ChannelFloat32 src, sensor_msgs.msg.ChannelFloat32 target)
    {
        target.Set(src);
    }


}


}