using System.IO;
namespace shape_msgs.msg
{

/**
* 
* Topic data type of the struct "Plane" defined in "Plane.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Plane.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Plane.idl instead.
*
*/
public class PlanePubSubType : Halodi.CDR.TopicDataType<Plane>
{
   public override string Name => "shape_msgs::msg::dds_::Plane_";


   public static int getCdrSerializedSize(shape_msgs.msg.Plane data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(shape_msgs.msg.Plane data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += ((4) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);
      return current_alignment - initial_alignment;
   }

   public static void write(shape_msgs.msg.Plane data, Halodi.CDR.CDRSerializer cdr)
   {
      for(int i0 = 0; i0 < 4; ++i0)
      {
        	cdr.write_type_6(data.coef[i0]);	
      }
   }

   public static void read(shape_msgs.msg.Plane data, Halodi.CDR.CDRDeserializer cdr)
   {
      for(int i0 = 0; i0 < 4; ++i0)
      {
        	data.coef[i0] = cdr.read_type_6();
        	
      }
      	

   }


	public override void Serialize(shape_msgs.msg.Plane data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(shape_msgs.msg.Plane data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(shape_msgs.msg.Plane data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(shape_msgs.msg.Plane src, shape_msgs.msg.Plane target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(shape_msgs.msg.Plane src, shape_msgs.msg.Plane target)
    {
    	Copy(src, target);
    }


}


}