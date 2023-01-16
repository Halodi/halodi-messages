using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "UInt16MultiArray" defined in "UInt16MultiArray.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from UInt16MultiArray.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit UInt16MultiArray.idl instead.
*
*/
public class UInt16MultiArrayPubSubType : Halodi.CDR.TopicDataType<UInt16MultiArray>
{
   public override string Name => "std_msgs::msg::dds_::UInt16MultiArray_";


   public static int getCdrSerializedSize(std_msgs.msg.UInt16MultiArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt16MultiArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.MultiArrayLayoutPubSubType.getCdrSerializedSize(data.layout, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.data.Count * 2) + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.UInt16MultiArray data, Halodi.CDR.CDRSerializer cdr)
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
      			cdr.write_type_3(data.data[i0]);
            }
        }
   }

   public static void read(std_msgs.msg.UInt16MultiArray data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.layout = std_msgs.msg.MultiArrayLayoutPubSubType.Create();
      std_msgs.msg.MultiArrayLayoutPubSubType.read(data.layout, cdr);
      	

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<ushort>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	data.data.Add(cdr.read_type_3());
      	
      	
      }

      	

   }


	public override void Serialize(std_msgs.msg.UInt16MultiArray data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.UInt16MultiArray data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.UInt16MultiArray data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.UInt16MultiArray src, std_msgs.msg.UInt16MultiArray target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.UInt16MultiArray src, std_msgs.msg.UInt16MultiArray target)
    {
    	Copy(src, target);
    }


}


}