using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "ColorRGBA" defined in "ColorRGBA.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ColorRGBA.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ColorRGBA.idl instead.
*
*/
public class ColorRGBAPubSubType : Halodi.CDR.TopicDataType<ColorRGBA>
{
   public override string Name => "std_msgs::msg::dds_::ColorRGBA_";


   public static int getCdrSerializedSize(std_msgs.msg.ColorRGBA data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.ColorRGBA data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.ColorRGBA data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_5(data.r);

      cdr.write_type_5(data.g);

      cdr.write_type_5(data.b);

      cdr.write_type_5(data.a);

   }

   public static void read(std_msgs.msg.ColorRGBA data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.r=cdr.read_type_5();
      	
      data.g=cdr.read_type_5();
      	
      data.b=cdr.read_type_5();
      	
      data.a=cdr.read_type_5();
      	

   }


	public override void Serialize(std_msgs.msg.ColorRGBA data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.ColorRGBA data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.ColorRGBA data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.ColorRGBA src, std_msgs.msg.ColorRGBA target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.ColorRGBA src, std_msgs.msg.ColorRGBA target)
    {
    	Copy(src, target);
    }


}


}