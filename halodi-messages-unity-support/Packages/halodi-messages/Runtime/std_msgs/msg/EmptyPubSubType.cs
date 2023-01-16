using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Empty" defined in "Empty.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Empty.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Empty.idl instead.
*
*/
public class EmptyPubSubType : Halodi.CDR.TopicDataType<Empty>
{
   public override string Name => "std_msgs::msg::dds_::Empty_";


   public static int getCdrSerializedSize(std_msgs.msg.Empty data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Empty data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Empty data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_7(data.unused_placeholder_field);

   }

   public static void read(std_msgs.msg.Empty data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.unused_placeholder_field=cdr.read_type_7();
      	

   }


	public override void Serialize(std_msgs.msg.Empty data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.Empty data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.Empty data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.Empty src, std_msgs.msg.Empty target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.Empty src, std_msgs.msg.Empty target)
    {
    	Copy(src, target);
    }


}


}