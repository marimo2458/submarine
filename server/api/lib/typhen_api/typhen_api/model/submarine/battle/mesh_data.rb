# This file was generated by typhen-api

module TyphenApi::Model::Submarine::Battle
  class MeshData
    include Virtus.model(:strict => true)

    attribute :vertices, Array[TyphenApi::Model::Submarine::Battle::Point], :required => true
    attribute :triangles, Array[Integer], :required => true
  end
end
