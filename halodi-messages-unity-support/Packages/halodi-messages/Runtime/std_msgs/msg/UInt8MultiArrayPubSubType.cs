using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "UInt8MultiArray" defined in "UInt8MultiArray.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from UInt8MultiArray.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit UInt8MultiArray.idl instead.
*
*/
public class UInt8MultiArrayPubSubType : Halodi.CDR.TopicDataType<UInt8MultiArray>
{
   public override string Name => "std_msgs::msg::dds_::UInt8MultiArray_";


   
   public override void serialize(std_msgs.msg.UInt8MultiArray data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.UInt8MultiArray data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt8MultiArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt8MultiArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.MultiArrayLayoutPubSubType.getCdrSerializedSize(data.layout, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.data.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.UInt8MultiArray data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.MultiArrayLayoutPubSubType.write(data.layout, cdr);

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

   public static void read(std_msgs.msg.UInt8MultiArray data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.layout = std_msgs.msg.MultiArrayLayoutPubSubType.Create();
      std_msgs.msg.MultiArrayLayoutPubSubType.read(data.layout, cdr);
      	

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<byte>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	data.data.Add(cdr.read_type_9());
      	
      	
      }

      	

   }


    public static void Copy(std_msgs.msg.UInt8MultiArray src, std_msgs.msg.UInt8MultiArray target)
    {
        target.Set(src);
    }


}


}