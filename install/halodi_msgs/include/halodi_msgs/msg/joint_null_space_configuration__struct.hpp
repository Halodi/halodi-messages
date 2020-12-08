// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/JointNullSpaceConfiguration.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_NULL_SPACE_CONFIGURATION__STRUCT_HPP_
#define HALODI_MSGS__MSG__JOINT_NULL_SPACE_CONFIGURATION__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'joint'
#include "halodi_msgs/msg/joint_name__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__JointNullSpaceConfiguration __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__JointNullSpaceConfiguration __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct JointNullSpaceConfiguration_
{
  using Type = JointNullSpaceConfiguration_<ContainerAllocator>;

  explicit JointNullSpaceConfiguration_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->q_nullspace = 0.0;
    }
  }

  explicit JointNullSpaceConfiguration_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->q_nullspace = 0.0;
    }
  }

  // field types and members
  using _joint_type =
    halodi_msgs::msg::JointName_<ContainerAllocator>;
  _joint_type joint;
  using _q_nullspace_type =
    double;
  _q_nullspace_type q_nullspace;

  // setters for named parameter idiom
  Type & set__joint(
    const halodi_msgs::msg::JointName_<ContainerAllocator> & _arg)
  {
    this->joint = _arg;
    return *this;
  }
  Type & set__q_nullspace(
    const double & _arg)
  {
    this->q_nullspace = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__JointNullSpaceConfiguration
    std::shared_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__JointNullSpaceConfiguration
    std::shared_ptr<halodi_msgs::msg::JointNullSpaceConfiguration_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const JointNullSpaceConfiguration_ & other) const
  {
    if (this->joint != other.joint) {
      return false;
    }
    if (this->q_nullspace != other.q_nullspace) {
      return false;
    }
    return true;
  }
  bool operator!=(const JointNullSpaceConfiguration_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct JointNullSpaceConfiguration_

// alias to use template instance with default allocator
using JointNullSpaceConfiguration =
  halodi_msgs::msg::JointNullSpaceConfiguration_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__JOINT_NULL_SPACE_CONFIGURATION__STRUCT_HPP_
