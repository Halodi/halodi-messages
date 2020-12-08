// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/ContactPointCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__STRUCT_HPP_
#define HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'parent_joint'
#include "halodi_msgs/msg/joint_name__struct.hpp"
// Member 'normal'
#include "geometry_msgs/msg/vector3__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__ContactPointCommand __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__ContactPointCommand __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct ContactPointCommand_
{
  using Type = ContactPointCommand_<ContainerAllocator>;

  explicit ContactPointCommand_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : parent_joint(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->contact_point_id = 0l;
      this->point_in_contact = false;
    }
  }

  explicit ContactPointCommand_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : parent_joint(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->contact_point_id = 0l;
      this->point_in_contact = false;
    }
  }

  // field types and members
  using _parent_joint_type =
    halodi_msgs::msg::JointName_<ContainerAllocator>;
  _parent_joint_type parent_joint;
  using _contact_point_id_type =
    int32_t;
  _contact_point_id_type contact_point_id;
  using _point_in_contact_type =
    bool;
  _point_in_contact_type point_in_contact;
  using _normal_type =
    rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other>;
  _normal_type normal;
  using _coefficient_of_friction_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _coefficient_of_friction_type coefficient_of_friction;
  using _maximum_contact_force_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _maximum_contact_force_type maximum_contact_force;
  using _rho_weight_divider_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _rho_weight_divider_type rho_weight_divider;

  // setters for named parameter idiom
  Type & set__parent_joint(
    const halodi_msgs::msg::JointName_<ContainerAllocator> & _arg)
  {
    this->parent_joint = _arg;
    return *this;
  }
  Type & set__contact_point_id(
    const int32_t & _arg)
  {
    this->contact_point_id = _arg;
    return *this;
  }
  Type & set__point_in_contact(
    const bool & _arg)
  {
    this->point_in_contact = _arg;
    return *this;
  }
  Type & set__normal(
    const rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other> & _arg)
  {
    this->normal = _arg;
    return *this;
  }
  Type & set__coefficient_of_friction(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->coefficient_of_friction = _arg;
    return *this;
  }
  Type & set__maximum_contact_force(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->maximum_contact_force = _arg;
    return *this;
  }
  Type & set__rho_weight_divider(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->rho_weight_divider = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::ContactPointCommand_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::ContactPointCommand_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__ContactPointCommand
    std::shared_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__ContactPointCommand
    std::shared_ptr<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const ContactPointCommand_ & other) const
  {
    if (this->parent_joint != other.parent_joint) {
      return false;
    }
    if (this->contact_point_id != other.contact_point_id) {
      return false;
    }
    if (this->point_in_contact != other.point_in_contact) {
      return false;
    }
    if (this->normal != other.normal) {
      return false;
    }
    if (this->coefficient_of_friction != other.coefficient_of_friction) {
      return false;
    }
    if (this->maximum_contact_force != other.maximum_contact_force) {
      return false;
    }
    if (this->rho_weight_divider != other.rho_weight_divider) {
      return false;
    }
    return true;
  }
  bool operator!=(const ContactPointCommand_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct ContactPointCommand_

// alias to use template instance with default allocator
using ContactPointCommand =
  halodi_msgs::msg::ContactPointCommand_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__STRUCT_HPP_
